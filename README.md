# Unity-Playground

Greetings, program! 

The Unity projects I work on can get pretty complex and contain a ton of distracting pieces. I created this repository, so that I would have a clean and empty Unity workspace where nothing can distract me. In big projects, compiling and build times can get really long, but here, I can test code much quicker.

I use this workspace during challenging tasks at work-related or personal Unity projects

##Sub-projects##

The assets-folder contains sub-folders, each containing the assets of small projects that I have worked on.

###BigDataPlayerPrefs###

Tested if Unity WebGL's playerprefs allow large amounts of text to be saved. I stored a book's chapter's worth of text. Worked like a charm.

###InputField###

Unity doesn't allow input fields to add new lines as the user writes multi-line inputs. I created a workaround that lets me make multi-line, expanding inputfields. The solution is a bit hacky, but I suspect that this feature could be added into future versions of Unity. There is no need to spend dozens of hours developing this. might as well use a slightly hacky solution that works.

###OpenLink###

Tested if it's possible to open a link in a new tab in WebGL. Turns out that it is!

###ParseUrl###

Tested a regular expression that lets me find all url-links from a string of text.

###PersistentPlayerPrefs###

Tested if Unity's playerprefs in WebGL persist across builds. Turns out that they do, but the location of the build and the name of the build need to be the exact same.

###Regex###

I had to create a script that would recognize if the name of a file is an image. I created a regular expression to detect if the file name is a png or jpg.

###RotationMatrix###

Boss told me I needed a way to rotate a texture. I created my own matrix dot product script, along with a simple rotation matrix script. Multiplying the rotation matrix with the UV-points of a mesh, allows me to rotate the texture by an angle.

###Singleton###

Took UnifyCommunity's Singleton script. I inherited three classes of my own from it, and experimented with using the singleton design pattern. It works pretty well, and lessens the amount of code I need to copy paste when I have a project that uses a lot of singletons.

###SuchADrag###

Practised using Unity's event handlers and event triggers, involving dragging and clicking.

###TextureToSprite###

Using Unity to fetch an image from the internet retrives the image as a Texture2D. Texture2D requires more draw-calls than a sprite, so sprite has better performance. Also, sprite has options with keeping the aspect ratio of the image. I made a simple script that converts a texture2D into a Unity sprite.

###What's with the duck?###

The duck is a test image I use, whenever I need an image for something.
