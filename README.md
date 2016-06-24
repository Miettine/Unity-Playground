# Unity-Playground

Greetings, program! 

The Unity projects I work on can get pretty complex and contain a ton of distracting pieces. I created this repository, so that I would have a clean and empty Unity workspace where nothing can distract me. In big projects, compiling and build times can get really long, but here, I can test code much quicker.

I use this workspace during challenging tasks at work-related or personal Unity projects

##Sub-projects##

The assets-folder contains sub-folders, each containing the assets of small projects that I have worked on.

###ClickAndGetImage###

Not created by me. Contains the assets of adding an image from the user's computer to WebGL.

###HDImageImport###

Modified version of ClickAndGetImage. I modified the code so that I can get a high-definition image from my computer.

###InputField###

Unity doesn't allow input fields to add new lines as the user writes multi-line inputs. I created a workaround that lets me make multi-line, expanding inputfields. The solution is a bit hacky, but I suspect that this feature could be added into future versions of Unity. There is no need to spend dozens of hours developing this. might as well use a slightly hacky solution that works.

###JsonParsing###

Practised using Json.Deserialize -function to retrieve JSON data from an API.

###OpenLink###

Tested if it's possible to open a link in a new tab in WebGL. Turns out that it is!

###ParseUrl###

Tested a regular expression that lets me find all url-links from a string of text.

###Regex###

I had to create a script that would recognize if the name of a file is an image. I created a regular expression to detect if the file name is a png or jpg.

###TextureToSprite###

Using Unity to fetch an image from the internet retrives the image as a Texture2D. Texture2D requires more draw-calls than a sprite, so sprite has better performance. Also, sprite has options with keeping the aspect ratio of the image. I made a simple script that converts a texture2D into a Unity sprite.
