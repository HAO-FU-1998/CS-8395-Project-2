# CS 8395 Special Topics - Augmented Reality

Project Two: Augmented Reality Book Cover

Author: Hao Fu    hao.fu@vanderbilt.edu

## Version: Unity3D: 2020.3.29f1  Vuforia Engine: 10.5.5  Low Poly Junkyard Models Pack: 1.0

# Description

I completed this project using Unity3D and Vuforia.

> Create a new project in Unity3D and import the Vuforia Engine package and Low Poly Junkyard Models Pack package;

> Create License and Target Database on Vuforia Developer Portal and import them into the project;

> Create a new scene, add a ARCamera and two image target as "front" and "back";

> For "front" image target, add a Text-TextMeshPro with the title and author, add some 3D models from Low Poly Junkyard Models Pack;

> For "back" image target, add two 3D Text (because Text-TextMeshPro has limitaion on showing lots of text on a book cover at given size), one shows the relevant information about the book, the other shows a short review of the book;

> Add a VirtualButton on "back" image target, create a C# Mono Script about it;

> In the script, define two public GameObjects and a public VirtualButtonBehaviour, in start(), give two functions OnButtonPressed and OnButtonReleased, set the active of one text as true and the other as false, in OnButtonPressed function, change the status between the two texts, and in OnButtonReleased, change it back to the initial;

> Bind the texts and VirtualButton in the scene with what we defined in the script, then build and run;

> Interact it using the book or given pictures of the front and back cover, the output is successful as expected.

# Limitation

Due to the natural design of the book, its back cover is poor in detail and doesn't have a good contrast, thus leading to the poor rating (3 out of 5) in the target manager. So it's harder to recognize the back than the front (5 out of 5). This limitation is showing in my video, where it takes around 20 seconds to recognize and show the text on the back, but the content on the front can be shown immediately.

# Download and Running

Download the whole project, open it in Unity Hub with the correct Unity3D edition (2020.3.29f1), then build and run it using any wanted platform (suggest using PC, Mac & Linux Standalone or Android), finally using the physical book (if have) or given pictures of the front and back cover to interact with it. 

# Video and Full Project

https://vanderbilt.app.box.com/folder/156937165731?utm_campaign=collab%20auto%20accept%20user&utm_medium=email&utm_source=trans
