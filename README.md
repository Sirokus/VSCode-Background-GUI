This is a Windows window program created based on the background extension uploaded by shalldie on VSCode.

This program aims to improve the original functionality of the extension as much as possible through window programs.

The biggest advantage of background shalldie is that I have only found the UseFront option on its extension so far, which means that turning it off allows the background image to be placed at the back of the code rather than overlaid on top, making the code difficult to read.

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

The most important thing is not to attempt to explore the boundaries of the program, as I haven't done any boundary testing. I can only guarantee that it runs roughly correctly from the normal process. Use it with caution and have a good day! :)



这是一个基于VSCode上由shalldie上传的background扩展制作的windows窗口程序。

该程序旨在通过窗口程序尽可能的完善该扩展原有的功能。

background - shalldie 的最大优势是我目前仅在其扩展上发现了UseFront的选项，这意味着关闭其可以让背景图片位于代码的后方，而不是叠加在代码上，使得代码变得难以阅读。

但于此同时，该扩展不支持输入壁纸文件夹和随机播放，其只支持通过单个文件的链接或路径进行添加，且有一定的上限。这对于我而言是十分苦恼的。

所以我作了这个窗口程序用来自动化的管理这个过程。这个程序实际上干了两件事，第一件事是解析壁纸目录，生成txt文件进行记录，第二件事是用txt文件上记录的壁纸地址替换掉VSCode的settings.json中的指定条目（background.customImages）

它的工作流程大致如下：

1. 指定壁纸根目录和VSCode的settings.json

2. 按下解析文件按钮，程序将会自动解析壁纸目录并生成多个txt记录文件

3. 在表格中选择一个壁纸组

4. 在右边的细节面板调整行为，这些行为与窗口程序和settings.json息息相关，并且不会去检测VSCode的settings.json中是否含有所需的字段，因此强烈建议你先在VSCode的settings.json上创建所需要在面板上自定义的条目

5. 点击随机顺序后，当前选择的包的顺序会被打乱

6. 点击应用当前壁纸组后，VSCode的settings.json会被替换，此时VSCode会提示重启窗口，重启后即应用修改（我尝试了各种办法，但最后还是不能在外部操纵VSCode的命令行为，因此该窗口程序仍然是一个半自动程序）

7. 勾选幻灯片播放后，每当到达一个GroupInternal后，系统会自动替换下一个组到settings.json中

8. 勾选自动随机后，系统自动替换前会自动进行一次打乱

9. 剩余的参数则是直接操作settings.json的字段的，按需使用

最重要的一点是，不要尝试探索该程序的边界，因为我一点边界测试都没做，我只能保证从正常流程运行的大致正确，小心使用，祝好运！:)
