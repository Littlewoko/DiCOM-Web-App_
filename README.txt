Here you'll find a user guide and a quick reflection on this task!
USER GUIDE: 
1.Open Visual Studio 2020 and open the solution.
2.Ensure SQL database is connected (I used SQLExpress localdb)
3.Run the program (Using start)
4.You should now see a windows form, using your dicom sender of choice send images over network to port 104. If these are correctly recieved you should see the first of these displayed within the window
5.Click (Digest Dicom to DB) which will begin (attempting) to iterate through each image and store them to your connected sql server in db "DiCOM_Web_App_.PatientContext"

...

REFLECTION:
Unfortunately this is the point at which I began butting up against a wall and simply ran out of time. This was a combination of working with unfamiliar 
frameworks and libraries, programming rust that i have yet to shake off and simply lack of experience! That is not to say i am disheartened however, i had alot of fun with this task
and although I did not manage to complete all parts of it (or really get it working at all) theres alot i can relfect on. Allow me to take you through my thought process at each stage 
and perhaps give some of what I may have done differently
1. I began by looking into entity framework code first. I had never used this before so it took some time reading through documentation and trying to sus together how it all worked. 
Luckily for me, it was fairly simple and by the end of day one I had a model i was reasonably happy with based on the assigned task and a server set up for receiving data. 

2. I then started planning how I would tackle the receiving of dicom images over the network. This took longer than it should have on relfection due to attempting to set up my own
Dicom Sender application. This wasnt all time lost as it allowed me time reading into the dicom objects library and the help guide available (which was a lifeline)

3. After realising i could just use the provided dicom viewer to send dicom over the network i started putting together my server. Although extremely barebones, i got this working and listening to 
port 104. 

4. Finally i began working on digesting the dicom and inserting these into the database which is where I got too caught up for my own good. Although some of the data was stored, it was not complete 
and there were clearly issues with the logic. Initially there were key conflicts and after trying to do presence checks on the data it just didnt seem to properly store all of the data. 
This got me flustered and I will have to admit that I tried hacking at it over and over when the best thing i could have done would be to step back, evaluate and start again/ break it into smaller problems. 

Unfortunately at this point i ran out of time, and i considered very quickly throwing together a web app to display the data that *was* in the db but decided against it. I knew this would be a 
hacky solution due to not being familiar with the .NET framework and libraries available to me at this point and would only work to further complicate a clear bug in the current environment. 

I think if i were to go back in time and start again I would have taken more time to get to grips with c# and the .NET framework as well as the entity framework code first libraries, which would 
have given me a stronger grounding to build upon rather than having to tear down and interate on broken code which lead to lost time and ultimately an unfinished product. 

I would like to add that although this is clearly a simplistic implementation (and a broken one at that haha) i am proud of what i have put together considering my unfamiliarity with all aspects
of this task. It highlighted to me areas that i have become *very* rusty, and clear ways forward for the future which is incredibly important to me. It also allowed me to prove to myself that
I am capable of getting over the initial overwhelm and breaking down a problem into smaller, digestible tasks. Given more time would I have been able to complete the task? Honestly i'm not sure, 
as my initial approach was fundamentally flawed, but I have learned alot from this and I have enjoyed the journey. 

I want to extend my thanks to Qian for the prompt responses to my queries (and helping me realise that I was allowing myself to get lost in the reeds when he answered the db storage question, what an obvious 
solution that i just couldnt see in the moment haha) and to Philippa for giving me the opportunity! 

I hope you will consider me in spite of the unfinished task :)