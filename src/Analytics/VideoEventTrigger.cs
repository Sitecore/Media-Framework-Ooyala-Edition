﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerEventTrigger.cs" company="Sitecore A/S">
//   Copyright (C) 2013 by Sitecore A/S
// </copyright>
// <summary>
//   The player event trigger.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.MediaFramework.Ooyala.Analytics
{
  using Sitecore.MediaFramework.Analytics;

  /// <summary>
  /// The player event trigger.
  /// </summary>
  public class VideoEventTrigger : EventTrigger
  {
    /// <summary>
    /// Inits events.
    /// </summary>
    public override void InitEvents()
    {
      this.AddEvent(TemplateIDs.Video, PlaybackEvents.PlaybackStarted.ToString(), "Ooyala video is started.");
      this.AddEvent(TemplateIDs.Video, PlaybackEvents.PlaybackCompleted.ToString(), "Ooyala video is completed.");
      this.AddEvent(TemplateIDs.Video, PlaybackEvents.PlaybackChanged.ToString(), "Ooyala video progress is changed.");
      this.AddEvent(TemplateIDs.Video, PlaybackEvents.PlaybackError.ToString(), "Ooyala video playback error.");
    }
  }
}