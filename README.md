Vivi player
===================

> **Task Audio:** Develope desktop application that loads a sound from a file and is capable of playing it, with a modification as well as without it. The modification's numeric parameters are adjustable via UI/

> **Task Video:**Develope a desktop application that loads one or more images from a file and displays them in a windows. Actions can also be performed on them, by using UI controls.

#####Actions

[Audio]: change balance of sound.

[Video]: play a video file stored on your computer.

-------------------

#####About [GrayScale][ref1].


Program Overview

![screen1](https://raw.githubusercontent.com/NicoBarbaros/Viviplayer/master/Img/2.png)


This example is for audio/video. We have a bottom area with a set of buttons for controlling the playback, a label for showing the status, and then a MediaElement control in the top area to show the actual video or not showing anything when we choose an mp3 file.

I create and start a timer, which ticks every second. We use this event to update the status timer_Tick toolbox, which will show the current progress , as seen on the screenshot.

The buttons each simply call a corresponding method on the MediaElement control - Play(), Stop(), Volume Up() and Volume Down().

> **Note:** Down bellow you can see in action how the application works.
---------------------
Video
[![ScreenShot](https://raw.githubusercontent.com/NicoBarbaros/Viviplayer/master/Img/1.png)](https://www.youtube.com/watch?v=esbH8fboN3o&feature=youtu.be)

#####Conclusion
	
Once again it's clear how easy WPF makes even advanced things like playing a video.

 [ref1]: http://whatis.techtarget.com/definition/grayscale

