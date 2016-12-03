#Project Managment Document for SchoolBook

**Prepared by:** 

	Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux

| Index         |
| --- |
| **1. Vision** |
|		1.1 Vision for SchoolBook      |
| **2. Configuration Management Plan** |
|		2.1			GitHub	|
| **3. Process Model** |
|		3.1			Phased Development	|
| **4. Deliverables** |
|		4.1        	Executables	|
|		4.2        	Documentation	|
|		4.3 		Manuals	|
| **5. Potential Risks**	|
|		5.1 		Human Risk 	|
|		5.2			Time Risk	|
|		5.3			Resources Risk	|
|		5.4			Liability Issues	|
| **6. Team Members**	
|		6.1			Team Style	|
|		6.2			Team Members and Roles		|
| **7. Project Schedule**	|
|		7.1			Gantt Chart	|
|		7.2			Milestones	|
|		7.3			Rough Estimates	|
|		7.4			Weekly Schedule	|
|		7.5			Estimation Method	|
| **8. Meetings Summary**	|
|		8.1			Meeting 1	|
|		8.2			Meeting 2	|
|		8.3			Meeting 3	|
|		8.4			Meeting 4	|
|		8.5			Meeting 5	|
|		8.6			Meeting 6	|
|		8.7			Meeting 7	|
|		8.8			Meeting 8	|
|		8.9			Meeting 9	|
|		8.10		Meeting 10	|
|		8.11		Meeting 11	|
|		8.12		Meeting 12	|

##1. Vision
**1.1 Vision**

  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;In a world with ever growing connectivity, why do we fail to connect with those who are not only the closest to us, but also share pursuits and interest with us? This problem is highlighted every year when a challenging test or exam is upon us. You realize you have 20+ other people in the same class, but yet you have no medium to connect. There seems to be a void when trying to attempt a task that's of upmost importance - sharing knowledge and providing intellectual growth with classmates. Moodle provides a method for professors to pass their information to students, if they choose, but aside from this sparingly used  one-to-many medium the transfer of information amongst a class is exceedingly difficult. This semester I've received numerous emails from students in the same class as me saying they don't have any partners for a group. This exclaims the desire and need for a system that eases the ability to connect students.   
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The goal of SchoolBook was to create and provide this system. To create an environment where students can: provide and receive an information they need regarding the classes they're currently taking, express struggles and have discussions on the solutions, easily connect and find students when studying or planning to study, expand their network, find tutors for available classes, reward academic success by allowing students to earn money as tutors.

##2. Configuration Management Plan
**2.1 GitHub**

GitHub was used to store our project so all team members could easily reach and update the project. Once a team member pushed an update to GitHub, they would let everyone know in GroupMe. Almost all programming was done side by side towards the end, so we resorted to transferring individuals files via usb. This was done to make sure the changed files would work with the other developer's database before being commited to our master branch.

##3. Process Model
**3.1 Phased Development**

Phased development was used so that subsystems could be divided amongst all team members. We chose to develop incrementally since all our features and designs build upon themselves. For example, our development cycles consisted of initially getting the data base created and online, then creating a simple webpage that properly communicated with the database, then optimizing the database to reduce webpage code, and then adding fonts and styles to the webpage. Each following development cycle followed the procedure of creating the desired server side webpage with the correct elements needed for it's functionality, adding the functionality to the webpage's front end, testing the functionality, connecting the page to the entire project, testing the project's functionality, and then lastly adding font and formatting to the page. 



##4. Deliverables
**4.1 Executables**

Our web application is developed in asp.net 4.0. As of now, the application does not have a dedicated server or established domain name, however, the awspx files are in the schoolbook directory folder on GitHub. It requires Microsoft Visual Studios 2015 to execute the web application. Double click the sln file within the school book folder and click on "run app" in the visual studio interface to run the web application. 

**4.2. Documentation**

4.2.1 Registration

The registration page will require users to enter their email (username) as well as create a password in order to start using the application. The page will require the user to enter their password a second time for verification.

4.2.2 Login

This page allows the user to enter their username and password and click the 'Login' button to enter the home page of their account.

4.2.3 Password Reset

If a user wants to reset their password, they must first login, and then will be allowed to reset their password to a new password of their choice. A password reset notification will appear when the password is reset.

Profile

4.2.4 Update Profile

The update profile page will allow users to change what is displayed on their page. This includes name, profile picture, summary, classification, classes, GPA, etc.

4.2.5 Add Course

Adding a course will require the user to find the department name, course abbreviation, and course number. Clicking Add Course will display the course page on the user's main profile page and add the user to that specific course. When a user adds a course, he will then be able to view notes, documents, classmates for that course.

4.2.6 Register as Tutor

A user has the option to register their account as a tutor. Tutors are chosen based on the grade in which they received in the course. Registering as a tutor in a course will require the 'Tutor' to find the department name, course abbreviation, course number, and professor. The 'Tutor' must also prove a grade of B- or above. Once a Tutor is registered and approved they will become available on the course page.

Study Groups

SchoolBook will allow users to setup and organize study groups for the courses they are enrolled in, the system will also allow users to request tutors for the study groups they setup.

4.2.7 Create Study Group

The create study group feature will allow users to setup a study group by specifying the proposed date and time, location, course, and if they request a tutor. Once they have successfully entered the study group information they are added to the study group and returned to the main page. The create study group page can be accessed from the home page menu.

4.2.8 Find Study Group

The find study group feature will allow uses to search for study groups based on the course department and ID. The system will present the user with a list of the upcoming scheduled study groups for that course. The find study group feature can be accessed from the home page menu.

4.2.9 Join Study Group

The join study group feature will allow users to join study groups from the find study group search results screen. Once a user has selected a study group from the find study group results page they will find the join study group button below the study group’s details. Once the user chooses to join the study group they are presented with a success / failure message and returns the user to the study group’s details page.

4.2.10 Leave Study Group

The leave study group feature will allow users to leave study groups that they have previously joined. The leave study group page will present the user with a list of study groups they have previously joined. The user will select the study group they wish to leave from the list. The system will display a confirmation prompt for the user, if the user confirms they are removed from the study group and returned to the home page. If the user denies the action the system returns the user back to the list of study groups they can leave without removing the user from the study group. The leave study group function can be found from the home page menu.

Notes

The note sharing features allows users to upload documents, class notes, and study tools for a specified course. Other users will be able to access these notes by accessing the course page for which the notes were originally uploaded to.

4.2.11 Upload Notes

The upload notes feature allows users to upload documents, class notes, and study tools for a specified course. To upload notes a user must navigate to their profile page from the home page menu. From there the user chooses the upload notes button, indicated by a large + icon. The user will specify the course department and ID as well as the year and semester which the notes are to be used for. The user will be able to browse their device for acceptable PDF documents to upload to SchoolBook. The system will display a success / failure message once the use has input all the required information.

4.2.12 Search For Notes

The search for notes feature will allow students to search and filter throughout the database for notes regarding specific courses. The top bar of the main page will provide users with a search bar. The user will be able to type in the search bar to specify the course department and ID for the course. The system will display a table of information for the notes that have been uploaded for that course including the file name and the note’s semester and year. The file names will by hyperlinks to the PDF document is here

**4.3 Manuals**

![Manual Index](https://i.imgsafe.org/21cf05ad41.png)

![Registration Login](https://i.imgsafe.org/21de64b6ee.png)

![Password Reset-Update Profile](https://i.imgsafe.org/21ed773fd3.png)

![Add Course-Register as Tutor](https://i.imgsafe.org/21ef73feb3.png)

![Create Study Group-Find Study Group-Join Study Group-Leave Study Group](https://i.imgsafe.org/21f131a7fe.png)

![Upload Notes-Search For Notes](https://i.imgsafe.org/21f290242a.png)

##5. Potential Risks
**5.1 Human Risk**

A team member dropping the course late in the semester could pose a risk due to the lack of contribution to the project. A Team member stating they would implement a certain portion of the code and not doing so. Falling behind on certain milestone pre determined at the beginning of the semester. Not properly committing to GitHub or potentially deleting someone else's commit. 

**5.2 Time Risk**

Time risk consist of the team members not submitting their portions of the project by the due date/time. The group as a whole not establishing a specific time and date for a meeting. 

**5.3 Resource Risk**

Resource risk was a factor due to the fact that some team members did not have a PC to access the code and database. The risk was resolved by remoting into a server setup by Clayton.

**5.4 Liability Issues**

The team was liable for ensuring that tutors met up in a safe place (on campus study spots) and not an unfamiliar area.

##6. Team Organization

**6.1 Team Style**

We chose to have a egoless group structure for the Schoolbook project. We chose this style because it would foster more ideas for the project.

**6.2 Team Members and Roles**

| Team Member	| Roles			| Reasons for Meeting Absense	| 
| ------------- | --------------------- | ----------------------------- |
| Zachary Robicheaux	| Documentation & Testing		| There were work/meeting conflicts for all 2 PM meetings.	|
| Sean Marino		| Documentation & Testing		| *Attended all meetings*					|
| Steffano Soh		| 1.Database Design & Implementation <br/> 2.Front End UI design & implementation<br/>3.Implementation of functionalities: Leave Study Group , Add Course , Upload / View Notes, Register as tutor. | *Attended all meetings* |
| Clayton Samson	| 1. Terminal Server setup and maintenance <br/> 2. Documentation and Testing | *Attended all meetings*|
|Nicholas Dugal		| 1. Back End design & implementation<br/> 2.Front End function creation, implementation, and testing <br/> 3. Created, Implemented, and Tested the following pages and any functions contained inside them: Login, Registration, Home Page, Create study group, Search for study group, Join study group, RegexUtilities, Logout, Forgot/Reset Password |*Missed a meeting. Can't remember why*|
| Justin Bougere	| Documentation & Testing		| *Attended all meetings*

##7. Project Schedule

**7.1 Gantt Chart**

![Gantt chart of project schedule](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/ProjectAdmin/Schedule/SchoolBookSchedule.png)

**7.2 Milestones**

1. Decide what platform to develop and determine structure of application, completed 9/7/2016.
2. Design and setup database, completed 9/19/2016.
3. Complete and submit the Software Requirements Specification (SRS) document, completed 8/21/2016.
4. Ensure all members have access to proper development platform, completed 9/25/2016.
5. Define all functional and non functional requirments in the Software System Design (SSD) document, completed 9/2/2016.
6. Develop registration, login and password reset functions, completed 9/7/2016.
7. Define test cases for full path coverage in the Software Testing Document, completed 9/21/2016. 
8. Develop Update profile, add course, and register as tutor functions, completed ...
9. Develop Create and Search for study group functions, completed ...
10. Develop join and leave study group functions, completed ...
11. Develop upload and search for notes functions, completed ...
12. Integrate profile, study group, and notes functions into the system, completed 11/28/2016.
13. Application presentation and demo for class and industry, completed 11/28/2016.


**7.3 Rough Estimates**

| Task Description	| Activity Label	| Tasks Precedence	| Expected Duration	(Weeks)	|
|-------------------|-------------------|-------------------|---------------------------|
| Decide what platform to develop, and determine structure of applicaton	| A	| None	| 1 |
| Design and setup database	| B	| A	| 1	|
| Ensure all members have access to proper development platcorm	| C	| A	|1.5 |
| Develop registration, login and password reset functions	| D	| C, B	|  2 |
| Develop Update profile, add course, and register as tutor functions	| E	| C, B	| 2 |
| Develop Create and Search for study group functions	| F	| C, B	| 2 |
| Develop join and leave study group functions	| G	| B, C, D	| 1 |
| Develop upload and search for notes functions	| H | B, C	| 2 |
| Integrate Study gruop and Notes functions	| I	| F, G, H	| 1 |
| Complete testing of application	| J	| I	| 2 |


**7.4 Weekly Schedule**

We met once or twice a week throughout the semester. We agreed tentatively to meet on Wednesday's at 2pm but also met a few times on Synday's at noon. 


|Team Implementation		| Week 1| Week 2| Week 3| Week 4| Week 5| Week 6| Week 7| Week 8| Week 9| Week 10| Week 11| Week 12|Week 13|




**7.5 Estimation Method**

| Algorithmic Methods	| Effort(Persons-Months)	|
|---------------------|------------------------|
| Walston & Felix	| 13.3990	|
|Bailey & Basili	| 7.9100	|

![COCOMO](https://i.imgsafe.org/2458710cd4.png)

##8. Meetings Summary

| Index number	| Meeting Date & Time	| Members Attending	| Objective	| Outcome |
| ------------- | --------------------- | ----------------- | --------- | ------- |
| 8.1	| 8/31/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Determine what software to develop	| Decided to create "SchoolBook" a web application which will allow students to better connect with each other. |
| 8.2	| 9/7/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Define main functions SchoolBook will provide	| Determined the web app will allow users to share notes, enroll in courses, setup study groups, and list onself as a tutor. |
| 8.3	| 9/14/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Define activities for each team member to work on and begin designing the data base.	| Nick will work on the sign up page design, Sean will work on the home page design, Clayton will work on class participants design, Zach will design the login screen, Justin will design the course page, and Steffano will complete the database design.	|
| 8.4	| 9/21/2016 - 2:00 PM	| Clayton Samson, Nicholas Dugal, Sean Marino, Steffano Soh	| Write mission statment, determine team organization for this project. | We completed the mission statment, and decided on an Egoless approach. |
| 8.5	| 10/19/2016 - 2:00 PM	| Clayton Samson, Justin Bougere, Sean Marino, Steffano Sho	| Come to a consensus on the functional requirments this system must implment, determine what may not be feasable to implment for this project.	| Came to an understanding of what the functional requirements for this system are, and determined who will document which requierments in the SRS document. We also decided that the gorup chat feature will not be feasable in the time allowed for this project.|
| 8.6	| 10/24/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Make sure everyone has visual studio and MySQL up and running correclty on their computer.| Determined that some team members computers are not capeable of running Visual Studio. Clayton will setup a terminal server to resolve this issue.	|
| 8.7	| 10/26/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano	| Defined tasks for the system design document based off of the functional requirements we defined in the SRS document.	| We assigned each team member sections of the SDD corresponding to the sections of the SRS document that team member wrote.	|
| 8.8	| 11/2/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Assign coding tasks to team members, and make sure everyone has access to MySQL and Visual Studio either on thier computer or from the terminal server Clayton setup.	| We assigned each team member a portion of the web app to begin coding, based off of how familiar the team member was with each function that needs to be written.	Clayton showed everyone how to remote into the terminal server and how to configure MySQL within their profile.	|
| 8.9	| 11/9/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Review coding progress and assign software testing document tasks to team  members.	| We made sure all of the team members understand how to access and manipluate the MySQL database from the web app in Visual Studio.  Assigned tasks to each team member to complete for the software testing document.|
| 8.10	| 11/21/2016 - 2:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Review software testing document before submission deadline.	| All group members were able to meet and review each others portion of the testing document and made final corretions before the submission deadline.	|
| 8.11	| 11/26/2-16 - 12:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Use pair programing to fix current bugs in the system.	| We were able to resolve many of the issues with individual functions, began testing these functions.	|
| 8.12	| 11/27/2016 - 12:00 PM	| Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux	| Finish individual functions and integrate the system.	| We were able to finish all of the individual funtions and began integrating them into one system.	|
