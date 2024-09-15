This is a Windows window program created based on the background extension uploaded by shaldie on VSCode.

This program aims to improve the original functionality of the extension as much as possible through window programs.

The biggest advantage of background shaddie is that I have only found the UseFront option on its extension so far, which means that turning it off allows the background image to be placed at the back of the code rather than overlaid on top, making the code difficult to read.

However, at the same time, the extension does not support inputting wallpaper folders and random playback. It only supports adding files through links or paths to a single file, with a certain limit. This is very distressing for me.

So I created this window program to automate the management of this process. This program actually does two things. The first thing is to parse the wallpaper directory and generate a txt file for recording. The second thing is to replace the specified entry (background. customImages) in VSCode's settings. json with the wallpaper address recorded in the txt file

Its workflow is roughly as follows:

1. Specify the wallpaper root directory and VSCode's settings. json
2. Press the parse file button, and the program will automatically parse the wallpaper directory and generate multiple txt record files
3. Select a wallpaper group from the table
4. Adjust the behavior in the details panel on the right, which is closely related to the window program and settings. json, and will not detect whether the VSCode settings. json contains the required fields. Therefore, it is strongly recommended that you first create the desired custom entries on the panel in VSCode settings. json
5. After clicking on the random order, the order of the currently selected packages will be scrambled
After clicking on the current wallpaper group in the application, the settings. json of VSCode will be replaced, and VSCode will prompt to restart the window. After restarting, the application will be modified (I tried various methods, but in the end, I still couldn't manipulate the command behavior of VSCode externally, so the window program is still a semi-automatic program)
7. After selecting the slide show, whenever a GroupInternational is reached, the system will automatically replace the next group in settings. json
8. After selecting automatic randomization, the system will automatically shuffle once before automatic replacement
9. The remaining parameters are directly operated on the fields of settings. json, and can be used as needed





