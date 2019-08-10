### Title
The Storyteller's Revenge

### Versions:
- GoogleVR SDK version 1.70.0
- Unity version 2017.2.0f3 Personal

### Description:
The start scene is the title scene named "Title"

This project was an excercise to stitch together either provided footage as flawlessly as possible in a way that makes coherent sense. All clips appear visually like they are in the same film.

There are controls for in-game play, pause and restart control for the film.

There is audio coming from one distinct source is set up correctly using the Google cardboard spatial audio spatializer (Resonance Audio Source).

It utilizes hotspots activated with a click to transition to a specific part of the film depending on user choice.

The credit sequence includes a particle effect.


### Notes:

1. The Film:

   - Stitching: Stitching took some time, but I eventually got the hang of it and I am happy with the results. The joins are not distracting. Several of the videos joined up really well.

    - Editing:I opted for a simple travel experience allowng a user to move between scenes, with a branched option to take the ferry home after a certain time period.

	- Coloring:	I managed to keep a somwewhat overcast look throughout.

	- Title and Credits: I used two methods for this. For the title screen I had a lot of fun with it. I used a tutorial I found to add the particle effect to the title screen. The particle effect was created to recreate sparks from a welding device hitting the ground and glowing, before extinguishing while the tour introduction is displated on screen. The credits were set to trigger after the 3rd video is played and animate up the screen to get the attention of the viewer.

2. Interactivity:

   - Cardboard: Cardboard controls are present. I@m currently extending to us the Daydream as I've recently gotten access to one.

   - Controls: Pause, restart and branch controls are present.

   - Spatial Audio: For each scene I used an animated sphere with an attached birdsong sound.

   - Choose your path: The user can choose to move the next scene, or take the ferry home with a branch option displaying 30 seconds into the first clip.

   - Particle effect: I opted to add a particle effect to the title screen.

### References and acknowledgments:
- AVPro Video https://assetstore.unity.com/packages/tools/video/avpro-video-windows-57969
- Post processing stack https://assetstore.unity.com/packages/essentials/post-processing-stack-83912
- Unity 2017 Tutorial - Sparks Particle Effect https://www.youtube.com/watch?v=MYU1vBcUkfw
