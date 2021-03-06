----------------------------------------------
                Koreographer™                 
    Copyright © 2014-2016 Sonic Bloom, LLC    
               Version 1.4.0                  
----------------------------------------------

Thank you for purchasing Koreographer™!

Use of the Koreographer™ software is bound to terms set forth in Unity's Asset Store Terms of Service and EULA:
http://unity3d.com/legal/as_terms

Credit where credit is due: please add the Koreographer™ logo to either the introduction credits sequence or the end credits sequence of your game or application.  Use of the Koreographer™ logo is to be implemented when credited, using the full color logo provided, at a size no smaller than 405px by 106px for the Logo and Title, and 106px by 106px for Logo only, in the logo’s native aspect ratio.

---------------------------------------
 Support, Documentation, and Tutorials
---------------------------------------

All can be found on the Koreographer™ website:
http://www.koreographer.com/

If you have any questions, suggestions, comments or feature requests, please see our support pages:
http://www.koreographer.com/support/

-----------------
 Version History
-----------------
* Items marked with the "[Pro]" tag are limited to the "Koreographer Professional Edition" package.

1.4.0 - Rhythm Game Demo!  Master Audio Integration!  FFT Audio Analysis!  Expanded APIs!  More responsive!

・[NEW] Rhythm Game Demo showing how to create a game with simple rhythm gameplay!  This also provides an example of using the Event Delay functionality to overcome issues related to audio latency.
・[NEW] [Pro] Master Audio integration!  Supports both Koreography Event triggering and the Music Time APIs.
・[NEW] [Pro] New FFT Audio Analysis method!  This includes a new Payload type (Spectrum Payload) that is generated by the FFT analysis and can be queried at runtime for frequency spectrum information!  Check out the new functionality by opening the Analysis Panel and clicking the FFT tab!
・[NEW] [Pro] Lyric Meta Event support added to the MIDI Converter.
・[NEW] The Koreography Editor no longer snaps at the beginning and end of a song to the edges of the screen; the waveform no longer jumps when pausing playback.
・[NEW] Lots of new functions added to the Music Time API!  Timings can now be accessed in Samples, Seconds, or Beats, and, yes, there's a BPM accessor!
・[NEW] Tempo Sections now support smooth tempo transitions!  If the new "Start New Measure" flag is unchecked, the time-in-beats will pick up where the previous Tempo Section left off.  [Pro] The MIDI Converter now unchecks this option by default, properly matching the way MIDI tempo changes are handled.
・[NEW] Timing calculations use 'double' instead of 'float' for far greater precision.
・[NEW] Report to the user if a previous Koreography processing pass did not finish properly.  This can occur if an exception is thrown from within a callback.
・[NEW] The Koreography Editor playhead can now be moved by beat as well as by measure (hold down the shift key while pressing left/right).
・[NEW] Support waveform rendering on Retina and HiDPI displays in the Koreography Editor (Unity 5.4+).
・[NEW] The waveform can now be "scratched" in the Koreography Editor by dragging with the middle mouse button during playback.
・[NEW] Koreographer's Music Players now have an IsPlaying property to quickly check the status of playback.
・[NEW] Koreographer's Music Players now support setting a target Koreographer component with which to interface.
・[NEW] Loaded Koreography can now be queried from a Koreographer component.
・[NEW] Improved the portability and performance of the KoreographyTrack event retrieval functions.  Old versions marked as Obsolete.
・[NEW] Added APIs to the Koreography class to retrieve Sample Time and Sample Time Delta values that are concurrent with the current (or most recent) Koreography Processing pass.
・Major optimizations to the waveform rendering system resulting in less memory consumption and faster computation.
・Slightly faster zooming by optimizing the waveform cache system.
・Fix for unloading Koreography during a callback causing undefined/difficult to track down errors/issues.
・Fix Koreography Editor issues related to changing the AudioClip (especially when setting it to "None").
・Fix showing the Scene tab when adding Koreography to a field in the Inspector.
・Fix unexpected selection box appearing when clicking on controls in the Koreography Editor.
・Fix for unresponsive Transport Displays (LCD readouts) in the Koreography Editor when clicking to change mode.
・Fix drawing waveforms upside down.
・Fix calculating Curve Payload deltas when the first key was not at time 0.
・Fix Audio Visor logic that used the global Koreographer component, ignoring a specified target Koreographer component.
・[Pro] Fix RMS Audio Analysis results not immediately appearing in the Koreography Editor when generated.
・[Pro] Fix an issue where Audio Analysis would fail to mark a Koreography Track as dirty when generating events.
・Fix not resetting internal Koreography time tracking values when loading a Koreography.
・Customized the script execution order of Koreographer's Audio Players to get them to update early.
・No longer allow creating Koreography Events beyond the end of the AudioClip.
・Removed the version of the GetAllEventsInRange API that had been previously marked as Obsolete.
・Remove reliance upon 'decimal' type in Koreographer functions.

1.3.0 - Koreographer/Pro Packages; New Integrations, Demos, and UI Enhancements!

・[NEW] Koreographer now comes in two editions: "Koreographer" and "Koreographer Professional Edition".  Owners of the original "Koreographer" package (release v1.2.0 and below) have been automatically upgraded to "Koreographer Professional Edition".  All changes prior to v1.3.0 refer to the "Professional Edition".  In the future, changes limited to the "Professional Edition" package will be marked with the "[Pro]" tag (as below).
・[NEW] [Pro] SECTR Audio integration!  Supports both Koreography Event triggering and the Music Time APIs.
・[NEW] [Pro] Audio Analysis: RMS Payload Generation!  Access by pressing the new "Analyze" button above the Waveform view in the Koreography Editor.
・[NEW] PlayMaker integration!
・[NEW] Karaoke Demo showing one way to use Koreographer to create sing-along lyrics!  (Note: Included in packages downloaded from the Asset Store with Unity 5.0.0 and above.)
・[NEW] "Payload Peek" UI: OneOff event Payloads now appear above the event when either selected or the mouse is hovering over them!
・[NEW] We've overhauled the Waveform drawing algorithm to improve speed across all supported versions of Unity!
・[NEW] Icons for Koreographer Assets and Components to help differentiate between types!
・[NEW] Middle-mouse button "click-to-drag" support for scrolling the Waveform view!
・Support for Unity 4.7.0 in source code package.
・Change Simple/MultiMusicPlayer "Auto Play On Start" to "Auto Play On Awake" to better mimic default AudioSource approach.
・Add public EventDelayInSeconds property to Koreographer component to allow runtime delay configuration.
・Fix pasting from right-click menu overwriting selection rather than pasting at current mouse position (when not over an event).
・Fix a very serious bug in the Koreography Editor on Windows that caused a copied payload to paste into selected Koreography Events when a Ctrl button was pressed.
・Fix horizontal scrolling of the Koreography Editor Waveform by scrolling a mouse wheel while holding the Shift key.
・Fix remembering Waveform display setting after zooming in all the way in the Koreography Editor.
・Fix a bug in the CubeScaler script that resulted in not actually evaluating CurvePayloads.
・Fix SimpleMusicPlayer causing a Null Reference Exception if started without Koreography set.
・[Pro] Fix duplicate Koreography Event in the ColorSmooth demo Koreography Track.
・[Pro] Renamed MIDI Converter's "Replace Events in Track" button with more clear "Overwrite Events in Track".
・Various minor performance optimizations.

1.2.0 - Full Platform Support and Load/Save Optimizations!

・[NEW] Support for all Windows Phone 8 and Windows Store build targets!  With these platforms joining the herd, Koreographer supports all platforms that Unity does (in Unity 4.5+)!
・[NEW] Massive simplification and optimizations to the KoreographyTrack serialization system!  Hurray performance!
・[NEW] MIDI Converter can now Append/Replace Koreography Events to/in a Koreography Track!
・[NEW] MIDI Converter now exports Raw Note and Velocity values as IntPayloads rather than FloatPayloads.
・[NEW] MIDI Converter Event ID field now has a dropdown with Event IDs found in Koreography throughout the project.
・New/Load operations in the Koreography Editor no longer lead to directories in other projects!
・Added a tooltip for the MIDI Converter's loaded file, showing the full path of the file.
・Fix some payload modifications not registering with Undo in the Koreography Editor.
・Fix Gradient Undo in certain circumstances.  Suffered the same issue as pre-1.1.0 AnimationCurves!
・Fix some script API documentation XML bugs.

1.1.0 - Core Optimizations and Integration Simplifications!

・[NEW] Add SampleRate field to Koreography.  Please either remove and readd your AudioClip in the Koreography Editor or adjust this value directly in the inspector!
・[NEW] Integration with Tazman Audio's Fabric audio engine!
・[NEW] HUGE fixes for runtime memory performance.  We tracked down a slew of minor allocations in the API that could add up quickly over time.  We think we got most of them but if you notice any allocations occurring, please let us know!
・[NEW] AudioSourceVisor component.  Enables simple Koreography Event triggering based on an associated AudioSource component (does not enable the Music Time API - use a Music Player if this is needed).
・[NEW] AnimationCurve undo support in the Koreography Editor.
・[NEW] Option to *not* auto-play music on Start() for SimpleMusicPlayer.
・[NEW] Option to *not* auto-play music on Start() for MultiMusicPlayer.
・[NEW] Detect when Unity's Audio System is disabled when using the Koreography Editor; offer to re-enable it.
・[NEW] Documentation for Koreographer's namespaces.
・[NEW] Core adjustments to make extending Koreographer easier by abstracting most of the "glue" visor code into the "VisorBase" class and removing AudioClip reference requirements on Koreography - matches now occur by name!
・Deprecate the "ProcessChoreography" function - use "ProcessKoreography" instead.
・Indent the "AudioClip" field in the Koreography Editor.
・Fix Koreography Events not triggering for a while after a pause due to Unity losing focus.
・Fix some tooltips in the MIDI Converter.
・Fix some documentation spelling/grammar.

1.0.1 - Documentation Updates!
・[NEW] Koreographer Quick Start Guide
・Unify some formatting across all documentation

1.0.0 - Initial Official Release!