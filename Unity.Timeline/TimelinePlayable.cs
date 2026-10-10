using System;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000049 RID: 73
	public class TimelinePlayable : PlayableBehaviour
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00009A84 File Offset: 0x00007C84
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			if (tracks == null)
			{
				throw new ArgumentNullException("Tracks list is null", "tracks");
			}
			if (go == null)
			{
				throw new ArgumentNullException("GameObject parameter is null", "go");
			}
			ScriptPlayable<TimelinePlayable> scriptPlayable = ScriptPlayable<TimelinePlayable>.Create(graph, 0);
			scriptPlayable.SetTraversalMode(PlayableTraversalMode.Passthrough);
			scriptPlayable.GetBehaviour().Compile(graph, scriptPlayable, tracks, go, autoRebalance, createOutputs);
			return scriptPlayable;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			if (tracks == null)
			{
				throw new ArgumentNullException("Tracks list is null", "tracks");
			}
			if (go == null)
			{
				throw new ArgumentNullException("GameObject parameter is null", "go");
			}
			List<TrackAsset> list = new List<TrackAsset>(tracks);
			int capacity = list.Count * 2 + list.Count;
			this.m_CurrentListOfActiveClips = new List<RuntimeElement>(capacity);
			this.m_ActiveClips = new List<RuntimeElement>(capacity);
			this.m_EvaluateCallbacks.Clear();
			this.m_PlayableCache.Clear();
			this.CompileTrackList(graph, timelinePlayable, list, go, createOutputs);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009B74 File Offset: 0x00007D74
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
		{
			foreach (TrackAsset trackAsset in tracks)
			{
				if (trackAsset.IsCompilable() && !this.m_PlayableCache.ContainsKey(trackAsset))
				{
					trackAsset.SortClips();
					this.CreateTrackPlayable(graph, timelinePlayable, trackAsset, go, createOutputs);
				}
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009BE0 File Offset: 0x00007DE0
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
		{
			if (track.isSubTrack)
			{
				return;
			}
			foreach (PlayableBinding playableBinding in track.outputs)
			{
				PlayableOutput output = playableBinding.CreateOutput(graph);
				output.SetReferenceObject(playableBinding.sourceObject);
				output.SetSourcePlayable(playable, port);
				output.SetWeight(1f);
				if (track as AnimationTrack != null)
				{
					this.EvaluateWeightsForAnimationPlayableOutput(track, (AnimationPlayableOutput)output);
				}
				if (output.IsPlayableOutputOfType<AudioPlayableOutput>())
				{
					((AudioPlayableOutput)output).SetEvaluateOnSeek(!TimelinePlayable.muteAudioScrubbing);
				}
				if (track.timelineAsset.markerTrack == track)
				{
					PlayableDirector component = go.GetComponent<PlayableDirector>();
					output.SetUserData(component);
					foreach (INotificationReceiver receiver in go.GetComponents<INotificationReceiver>())
					{
						output.AddNotificationReceiver(receiver);
					}
				}
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009CE8 File Offset: 0x00007EE8
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
		{
			this.m_EvaluateCallbacks.Add(new AnimationOutputWeightProcessor(animOutput));
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00009CFB File Offset: 0x00007EFB
		private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput)
		{
			this.m_EvaluateCallbacks.Add(new AnimationPreviewUpdateCallback(animOutput));
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009D10 File Offset: 0x00007F10
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
		{
			if (!track.IsCompilable())
			{
				return timelinePlayable;
			}
			Playable result;
			if (this.m_PlayableCache.TryGetValue(track, out result))
			{
				return result;
			}
			if (track.name == "root")
			{
				return timelinePlayable;
			}
			TrackAsset trackAsset = track.parent as TrackAsset;
			Playable playable = (trackAsset != null) ? this.CreateTrackPlayable(graph, timelinePlayable, trackAsset, go, createOutputs) : timelinePlayable;
			Playable playable2 = track.CreatePlayableGraph(graph, go, this.m_IntervalTree, timelinePlayable);
			bool flag = false;
			if (!playable2.IsValid<Playable>())
			{
				string name = track.name;
				string str = "(";
				Type type = track.GetType();
				throw new InvalidOperationException(name + str + ((type != null) ? type.ToString() : null) + ") did not produce a valid playable.");
			}
			if (playable.IsValid<Playable>() && playable2.IsValid<Playable>())
			{
				int inputCount = playable.GetInputCount<Playable>();
				playable.SetInputCount(inputCount + 1);
				flag = graph.Connect<Playable, Playable>(playable2, 0, playable, inputCount);
				playable.SetInputWeight(inputCount, 1f);
			}
			if (createOutputs && flag)
			{
				this.CreateTrackOutput(graph, track, go, playable, playable.GetInputCount<Playable>() - 1);
			}
			this.CacheTrack(track, playable2, flag ? (playable.GetInputCount<Playable>() - 1) : -1, playable);
			return playable2;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009E2C File Offset: 0x0000802C
		public override void PrepareFrame(Playable playable, FrameData info)
		{
			this.Evaluate(playable, info);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009E38 File Offset: 0x00008038
		private void Evaluate(Playable playable, FrameData frameData)
		{
			if (this.m_IntervalTree == null)
			{
				return;
			}
			double time = playable.GetTime<Playable>();
			this.m_ActiveBit = ((this.m_ActiveBit == 0) ? 1 : 0);
			this.m_CurrentListOfActiveClips.Clear();
			this.m_IntervalTree.IntersectsWith(DiscreteTime.GetNearestTick(time), this.m_CurrentListOfActiveClips);
			foreach (RuntimeElement runtimeElement in this.m_CurrentListOfActiveClips)
			{
				runtimeElement.intervalBit = this.m_ActiveBit;
			}
			double rootDuration = (double)new DiscreteTime(playable.GetDuration<Playable>());
			foreach (RuntimeElement runtimeElement2 in this.m_ActiveClips)
			{
				if (runtimeElement2.intervalBit != this.m_ActiveBit)
				{
					runtimeElement2.DisableAt(time, rootDuration, frameData);
				}
			}
			this.m_ActiveClips.Clear();
			for (int i = 0; i < this.m_CurrentListOfActiveClips.Count; i++)
			{
				this.m_CurrentListOfActiveClips[i].EvaluateAt(time, frameData);
				this.m_ActiveClips.Add(this.m_CurrentListOfActiveClips[i]);
			}
			int count = this.m_EvaluateCallbacks.Count;
			for (int j = 0; j < count; j++)
			{
				this.m_EvaluateCallbacks[j].Evaluate();
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009FB8 File Offset: 0x000081B8
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
		{
			this.m_PlayableCache[track] = playable;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009FC7 File Offset: 0x000081C7
		private static void ForAOTCompilationOnly()
		{
			new List<IntervalTree<RuntimeElement>.Entry>();
		}

		// Token: 0x040000F5 RID: 245
		private IntervalTree<RuntimeElement> m_IntervalTree = new IntervalTree<RuntimeElement>();

		// Token: 0x040000F6 RID: 246
		private List<RuntimeElement> m_ActiveClips = new List<RuntimeElement>();

		// Token: 0x040000F7 RID: 247
		private List<RuntimeElement> m_CurrentListOfActiveClips;

		// Token: 0x040000F8 RID: 248
		private int m_ActiveBit;

		// Token: 0x040000F9 RID: 249
		private List<ITimelineEvaluateCallback> m_EvaluateCallbacks = new List<ITimelineEvaluateCallback>();

		// Token: 0x040000FA RID: 250
		private Dictionary<TrackAsset, Playable> m_PlayableCache = new Dictionary<TrackAsset, Playable>();

		// Token: 0x040000FB RID: 251
		internal static bool muteAudioScrubbing = true;
	}
}
