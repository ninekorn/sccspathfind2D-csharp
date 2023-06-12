using sharpdx libraries


[b]c# variant zombie/skeleton builder/creator rev 0.1002 - works with cryofall v1.33.1.15:[/b]
List of changes:

1. i inserted the code inside of a thread so that the creation of the variant mobs happen faster. 
2. i added better console debug messages in order to know what the program is doing.

I started working on trying to also build/create variant mobs for the original game in order to make variants of it but this isn't working yet. What it means, is that in my next revisions, even the original mobs of cryofall should be able to be multiplied into variants. I am just not done with that yet.

download links:

compiled exe - https://github.com/ninekorn/sccspathfind2D-csharp/tree/main/Cryofall/modding%20tool/sccsr16-compiled/Release-rev0.1002/net6.0-windows

uncompiled - https://github.com/ninekorn/sccspathfind2D-csharp/tree/main/Cryofall/modding%20tool/sccsr16-uncompiled

[b]c# variant zombie/skeleton builder/creator rev 0.1000 - works with cryofall v1.33.1.15:[/b]

hey everyone. i released a 10min ish tutorial on youtube for how to instantly make skeleton/zombie variants with the variantbuilder modding tool i released on github but you can also read the steps below. It doesn't get you started on learning c# as it really is a draft though and not a very good example of organisation in code. Below is the tutorial on how to use this skeleton/zombie mobs variant builder/creator and it would be preferable to get to know how to install a mod in Cryofall first and i left a link at step 9 to get started with modding Cryofall or Void Expanse.

https://youtu.be/69ZQ-97tA84

rev 0.1000 WIP - c# mob variant builder/creator. Now this project sccsr16-mobcreator does what i had described earlier, but it does it all at the same time and it is much more simplified.

1. download my repository of approx 30 megabytes here https://github.com/ninekorn/sccspathfind2D-csharp/blob/main/Cryofall/modding%20tool/
2. retrieve and deposit (copy/paste) the folder #Cryofallscriptgen from sccspathfind2D-csharp/Cryofall/moddingtool/#Cryofallscriptgen, on your desktop. It contains my mods zombie.mpk and skeleton.mpk and zones.mpk inside of the folder #Cryofallscriptgen/original, if they aren't there you can go and get them separately as zipped file in the folder sccspathfind2D-csharp/Cryofall/moddingtool/#backups of the 1st step download to unzip them into the folder #Cryofallscriptgen/original.
3. retrieve and deposit (copy/paste) zombie.mpk and skeleton.mpk and zones.mpk in your Documents/Cryofall/Mods folder. You can find zombie.mpk and skeleton.mpk and zones.mpk inside of #Cryofallscriptgen/original/ or in ccspathfind2D-csharp/Cryofall/moddingtool/#backups/ as zipped files which you would have to unzip.
4. If the folder #Cryofallscriptgen/multiplied doesn't exist in the folder #Cryofallscriptgen, then create it. Otherwise i think this program now takes care of creating it for you.
5. find sccspathfind.mpk in the folder sccspathfind2D-csharp/Cryofall/moddingtool/#backups/sccspathfind.mpk.zip and unzip that folder in your Documents/Cryofall/Mods. Make sure that inside of the unzipped that there isn't another folder sccspathfind.mpk which would make the path Documents/Cryofall/Mods/sccspathfind.mpk/sccspathfind.mpk/Content. If this is what happened, then you need to cut/paste the sccspathfind.mpk/content back onto Documents/Cryofall/Mods and both folders Documents/Cryofall/Mods/sccspathfind.mpk will be merged. Make sure this didn't happen either for any of the other mods that needed unzipping.
6. From the folder sccspathfind2D-csharp/Cryofall/moddingtool/sccsr16-compiled of the 1st step, you can find the sccsr16.exe that you can launch. Let it do it's thing and after you see the line "sccsgraphicssec init_update_variables" in the console, then the work is done. You can find your multiplied variants mobs/monsters scripts and pngs inside of the folder #Cryofallscriptgen/multiplied. Copy/Paste or Cut/Paste the folders zombie.mpk and skeleton.mpk and zones.mpk, from #Cryofallscriptgen/multiplied, into Documents/Cryofall/Mods over the original zombie.mpk and skeleton.mpk and zones.mpk that you put there in step 2.
7. modify the insides of modsconfig.xml so that your desktop path is set instead of mine so that Cryofall finds the mods in Documents/Cryofall/Mods otherwise, you can find my ModsConfig.xml in the path sccspathfind2D-csharp/Cryofall/moddingtool/#backups/ModsConfig.xml and copy/paste it in your Documents/Cryofall/Mods folder.
8. from Documents/Cryofall/Mods, open the file ModsConfig.xml that you have just pasted there at the last step and where below is the path of my desktop/documents with my name steve you should change that name and make corrections if needed for the correct path to your Documents/Cryofall/Mods:


    <?xml version="1.0" encoding="utf-8" standalone="yes"?>
    <mods>
      <unpacked_mod>
        <mod_id>core_1.0.0</mod_id>
        <is_core_mod>1</is_core_mod>
        <path>Core/Core.cpk</path>
      </unpacked_mod>
      <unpacked_mod>
        <mod_id>sccspathfind</mod_id>
        <is_core_mod>0</is_core_mod>
        <path>C:\Users\steve\Documents\AtomicTorchStudio\CryoFall\Mods\sccspathfind.mpk</path>
      </unpacked_mod>
      <unpacked_mod>
        <mod_id>Skeleton</mod_id>
        <is_core_mod>0</is_core_mod>
        <path>C:\Users\steve\Documents\AtomicTorchStudio\CryoFall\Mods\Skeleton.mpk</path>
      </unpacked_mod>
      <unpacked_mod>
        <mod_id>Zombie</mod_id>
        <is_core_mod>0</is_core_mod>
        <path>C:\Users\steve\Documents\AtomicTorchStudio\CryoFall\Mods\Zombie.mpk</path>
      </unpacked_mod>
      <unpacked_mod>
        <mod_id>Zones</mod_id>
        <is_core_mod>0</is_core_mod>
        <path>C:\Users\steve\Documents\AtomicTorchStudio\CryoFall\Mods\Zones.mpk</path>
      </unpacked_mod>
    </mods>


9. Make sure that your core.cpk in your path C:\Program Files (x86)\Steam\steamapps\common\CryoFall\Core is unpacked. In order to unpack a core.cpk in order to mod Cryofall or Void Expanse, you can follow the tutorial here https://www.youtube.com/watch?v=c-qHWtr8Om0&t=1s where i show how to unpack core.cpk but for Void Expanse and it's the same for Cryofall. you can also unpack by double clicking C:\Program Files (x86)\Steam\steamapps\common\CryoFall\Core\Extract Core and Mods.cmd to unpack core.cpk.

For a more detailed info on where to modify the code of this program to have higher color difference on the skeleton/zombies images/PNGS, please watch the stream here:
https://studio.youtube.com/video/Ltg8vkTV4L8/edit.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# sccspathfind 2D - my javascript ecmascript5 2d pathfind development to c# - integrated in Unity3D/Cryofall/VoidExpanse
This is my c# translation of my work i did on my mods for the game void expanse in javascript ecmascript5. I had worked a lot on pathfind from 2017-2019 and had taken as reference the Sebastian Lague pathfind tutorial on youtube. I first built my version in c# and it is very similar if not identical to the beginnings of the sebastian lagues pathfind tutorial and barely modified. But in void expanse i had to develop something different as initialising big pathfind grids were lagging VE and i had to script in javascript ecmascript 5 initially and it was weeks of work. I still don't even reunderstand fully my own development technique anymore in 2023. Hopefully it will come back to me. At least i was able to translate it so i am very happy here. This is approx a correct translation of my work on pathfind in javascript ecmascript 5 in my void expanse mods to c#. But somehow i had to work differently with the position of the objects compared to how i did it in my mods for void expanse.

<img src="https://i.ibb.co/NtRCGg6/sccspathfind-0.jpg" alt="sccspathfind-0" border="0">
<img src="https://i.ibb.co/KVJQqg5/sccspathfind-1.jpg" alt="sccspathfind-1" border="0">

I have decided to release my c# pathfind development with the apache license 2.0, and decided to share my development to help with Cryofall mods. If i can successfully or not incorporate my c# pathfind development into Cryofall, which i should be able to if i start learning the cryofall c# API soon, doesn't matter anymore as i have finally released it and with the apache license 2.0 which is very permissive, so that others in the community might like my approach and use my pathfind "library/scripts" although Sebastian Lagues pathfind and other libraries are also great.  Basically as far as i understand, the Apache License 2.0 all sums up to referencing my name and work (including the work of others i reference in my own work) if you use my copies in other softwares you distribute or something close to that. I am unsure if this license choice was the right license to choose though, but i read on the internet it can protect a patent better, as i have not plagiarized my creation, and that it is compatible with the MIT license. I did use as reference the knowledge and a little bit of the code as reference from Sebastian Lague's pathfind tutorial on youtube (hosted on github.com MIT licensed), but not all of the code as linking grids together is something i developed on my own and fetching the index of grids in spiral is something i developed on my own and using premade arrays of unwalkable tiles and use the index is something i developed on my own, i didn't use as reference more than 1-2 episodes of Sebastian Lague's youtube pathfind tutorial which had helped me finally understand pathfinding in programming. Don't believe me? read my code, as this is a direct translation of my void expanse mod pathfind from javascript ecmascript5 to c# and i tried to be the most truthful i could be of my own development in my mods for void expanse for this c# translation. And i repeat, the architecture of how pathfind works, is very well explained in the first tutorial of pathfind of sebastian lague on youtube, and i use quite the hierarchy explained in the first video of the tutorial of sebastian lague. And unfortunately in the beginning my goal was to do a perfect translation of Sebastian Lagues pathfind tutorial on youtube to javascript ecmascript 5 strict mode, but i didn't have multithreading, i didn't have pathfind visible path, i didn't have anything. So i had to develop an alternative solution to reduce the weight of the pathfind for each script/drone that would use the script in my void expanse mods. Now, i have finally translated that work from javascript ecmascript5 to c#. Currently, i only made the pathfind work for the station exterior outpost, models that i had built for use in void expanse mods. I do not know how fast it fares against other pathfind techniques though. But currently my revision is not multithreaded and it is not using compute shaders for faster pathfind calculations. But no, i am not developing a void expanse game in unity. What i am doing was translating my pathfind from my void expanse mods in javascript ecmascript5, to c#, in order to use my pathfind for cryofall c# modding among using it with my own c# personal projects.

But please note that i have a lot of work left to do on adding every reference to others work including references from my own work that i move left and right everywhere in the projects that i make. I will try and work on that soon.

Controls:
movements W-A-S-D and SPACE to stop

The debug.drawline is for the editor view, and this is a draft/wip project and it had to work, not be a game.

