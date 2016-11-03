# Software Requirements Specification for SchoolBook

**Prepared by:** 

Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux

**Date Prepared: 10/26/2016**


| Table of Contents         |
| --- |
| **1. Introduction**                 |
|      1.1        Purpose        |
|      1.2        Intended Audience        |
|      1.3        Scope        |
|      1.4        Design Summary        |
| **2. Conceptual System Architecture**   |
|      2.1        Overview        |
|      2.2        Accounts <br/> &nbsp;&nbsp; 2.2.1     Registration<br/> &nbsp;&nbsp; 2.2.2     Login<br/> &nbsp;&nbsp; 2.2.3     Password Reset|   
|      2.3        Profiles<br/> &nbsp;&nbsp; 2.3.1     Update Profile<br/> &nbsp;&nbsp; 2.3.2     Add Course<br/> &nbsp;&nbsp; 2.3.3     Register as Tutor        |
|      2.4        Study Groups<br/> &nbsp;&nbsp; 2.4.1     Create Study Group<br/> &nbsp;&nbsp; 2.4.2     Find Study Group<br/> &nbsp;&nbsp; 2.4.3     Join Study Group<br/> &nbsp;&nbsp; 2.4.4     Leave Study Group        |
|      2.5        Notes<br/> &nbsp;&nbsp; 2.5.1    Upload Notes<br/> &nbsp;&nbsp; 2.5.2     Search for Notes        |
| **3. Techinical System Architecture** |
|      3.1        Overview        |
|      3.2        Accounts <br/> &nbsp;&nbsp; 3.2.1     Registration<br/> &nbsp;&nbsp; 3.2.2     Login<br/> &nbsp;&nbsp; 3.2.3     Password Reset|   
|      3.3        Profiles<br/> &nbsp;&nbsp; 3.3.1     Update Profile<br/> &nbsp;&nbsp; 3.3.2     Add Course<br/> &nbsp;&nbsp; 3.3.3     Register as Tutor        |
|      3.4        Study Groups<br/> &nbsp;&nbsp; 3.4.1     Create Study Group<br/> &nbsp;&nbsp; 3.4.2     Search for Study Group<br/> &nbsp;&nbsp; 3.4.3     Join Study Group<br/> &nbsp;&nbsp; 3.4.4     Leave Study Group        |
|      3.5        Notes<br/> &nbsp;&nbsp; 3.5.1    Upload Notes<br/> &nbsp;&nbsp; 3.5.2     Search for Notes        |
| **4. Application Views** |
|      4.1        Logical View       |
|      4.2        Physical View         |
|      4.3        Developement View       |
|      4.4        Work-Assignment View        |
| **5. User-Interface Design** |
|      5.1        User-Interface Description        |
|      5.2        User-Interface Diagrams        |
| **6. Database Design** |
|      6.1        Database Description      |
|      6.2        Database ER Diagram       |
| **7. Element Catalog**  |


# 1. Introduction

##  1.1 Purpose
 *Content Here*

##  1.2 Intended Audience
 *Content Here*

##  1.3 Scope
 *Content Here*

##  1.4  Design Summary
 *Content Here*

# 2. Conceptual System Architecture

## 2.1 Overview
<p> The following sections will describe the structure, behavior, and views of the systems architecture. </p>

##  2.2 Accounts
###  2.2.1 Registration
<p> The registration page will require users to enter their email (username) as well as create a password in order to start using the application. The page will require the user to enter their password a second time for verification. </p>

###  2.2.2 Login
<p> This page allows the user to enter their username and password and click the 'Login' button to enter the home page of their account. </p>

###  2.2.3 Password Reset
<p> If a user wants to reset their password, they must first login, and then will be allowed to reset their password to a new password of their choice. A password reset notification will appear when the password is reset. </p>

##  2.3 Profile

###  2.3.1 Update Profile
<p> The update profile page will allow users to change what is displayed on their page. This includes name, profile picture, summary, classification, classes, GPA, etc. </p>

### 2.3.2 Add Course
<p> Adding a course will require the user to find the department name, course abbreviation, and course number. Clicking Add Course will display the course page on the user's main profile page and add the user to that specific course. When a user adds a course, he will then be able to view notes, documents, classmates for that course. </p>

### 2.3.3 Register as Tutor
<p> A user has the option to register their account as a tutor. Tutor's are chosen based on the grade in which they received in the course. Registering as a tutor in a course will require the 'Tutor' to find the department name, course abbreviation, course number, and professor. The 'Tutor' must also prove a grade of B- or above. Once a Tutor is registered and approved they will become available on the course page. </p>

## 2.4 Study Groups
<p> SchoolBook will allow users to setup and organize study groups for the courses they are enrolled in, the system will also allow users to request tutors for the study groups they setup. </p>

### 2.4.1 Create Study Group
<p>The create study group feature will allow users to setup a study group by specifying the proposed date and time, location, course, and if they request a tutor.  Once they have successfully entered the study group information they are added to the study group and returned to the main page.  The create study group page can be accessed from the home page menu. </p>

### 2.4.2 Find Study Group
<p> The find study group feature will allow uses to search for study groups based on the course department and ID. The system will present the user with a list of the upcoming scheduled study groups for that course. The find study group feature can be accessed from the home page menu. </p>

### 2.4.3 Join Study Group
<p>The join study group feature will allow users to join study groups from the find study group search results screen. Once a user has selected a study group from the find study group results page they will find the join study group button below the study group’s details.  Once the user chooses to join the study group they are presented with a success / failure message and returns the user to the study group’s details page. </p>

### 2.4.4 Leave Study Group
<p>The leave study group feature will allow users to leave study groups that they have previously joined. The leave study group page will present the user with a list of study groups they have previously joined.  The user will select the study group they wish to leave from the list.  The system will display a confirmation prompt for the user, if the user confirms they are removed from the study group and returned to the home page. If the user denies the action the system returns the user back to the list of study groups they can leave without removing the user from the study group. The leave study group function can be found from the home page menu. </p>

## 2.5 Notes
<p> The note sharing features allows users to upload documents, class notes, and study tools for a specified course. Other users will be able to access these notes by accessing the course page for which the notes were originally uploaded to. </p>

### 2.5.1 Upload Notes
<p> The upload notes feature allows users to upload documents, class notes, and study tools for a specified course.  To upload notes a user must navigate to their profile page from the home page menu.  From there the user chooses the upload notes button, indicated by a large + icon.  The user will specify the course department and ID as well as the year and semester which the notes are to be used for. The user will be able to browse their device for acceptable PDF documents to upload to SchoolBook.  The system will display a success / failure message once the use has input all the required information. </p>

### 2.5.2 Search For Notes
<p>The search for notes feature will allow students to search and filter throughout the database for notes regarding specific courses. The top bar of the main page will provide users with a search bar. The user will be able to type in the search bar to specify the course department and ID for the course. The system will display a table of information for the notes that have been uploaded for that course including the file name and the note’s semester and year. The file names will by hyperlinks to the PDF documents. </p>

# 3. Techinical System Architecture

## 3.1 Overview
The following sections will describe how the app will accomplish each system.

##  3.2 Accounts

###  3.2.1 Registration
The user will enter a username and password, which will be saved together in a database as their account. 

###  3.2.2 Login
The user will enter their username and password. The app will then search through the database in order to verify that the username and password is correct. If the entered parameters don't match with an account on the database, the app will display a login error.

###  3.2.3 Password Reset
The user will enter their email address and new password. The app will then construct and email which will include a link to a page that will change the previous password located in the database to the new password.

##  3.3 Profile

###  3.3.1 Update Profile
The user will enter/edit their name, profile picture, summary, classification or GPA. The app will then update the user's account in the database with what they typed (for all but profile picture), or to a link to an image (for the profile picture).

### 3.3.2 Add Course
<p>The add course component allows the user to add a course to their profile. The user will enter their current university that they're attending. User then will be prompted to select the department, course name and course section. If the user selects a university that they are currently attending or have attended, they will not be able to access the courses. The course will not be added to the user's profile page.</p>

### 3.3.3 Register as Tutor
The register tutor component is responsible for approving or denying a profile user as a course tutor. will select the university department and course name they wish to be assigned as a designated tutor. The user will then upload a PDF file through an FTP of their transcript with the course grade the user earned. Once the file has been uploaded, a site admin will access the file. If the user has a grade below B-, the user will not become a registered tutor. If the user has a grade of a B- or higher, then the user will receive an The user will be manually approved by a site adminstrator.  

## 3.4 Study Groups

### 3.4.1 Create Study Group
The create study group component is responsible for allowing the user to establish a study group within the desired course registered on the user's profile. The component will register the student within the study group once it has been approved that the student has the course registered on their profile.  

### 3.4.2 Search for Study Group
The search for study group component allows a user to find a specific study group attached to a course. The component will aggregate a list of created study groups attached to the specific course. 

### 3.4.3 Join Study Group
The join study group component lets the user join a study group the user has searched for. Once the user selects the group, the component will add the user to the study group if the user has the course attached to their profile page. 

### 3.4.4 Leave Study Group
The leave study group component will let the user drop themselves from a group. The component will remove the user's profile from the study group if the user inputs and chooses to opt out of the group. 

## 3.5 Notes

### 3.5.1 Upload Notes
The upload notes component is responsible for sending any notes for the user's course to their profile and study group. The user will be prompted to upload formatted file to the site's FTP. The component will then retrieve the file and add it to the study group and user's profile. If the user does not upload the properly predetermined format on the file, the component will not add the file to the study group. 

### 3.5.2 Search For Notes
The search for notes component is responsible for letting the user find any notes that are attached to a study group. The component will collect a list of previously uploaded notes and allow the user to select the notes. Once selected, the component will allow the user  to view the notes.

# 4. Application Views

## 4.1 Logical View
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/LogicalView.gif)

## 4.2 Physical View  
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/PhysicalView.gif)

## 4.3 Developement View
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/DevelopementView.gif)

## 4.4 Work-Assignment View

Work Assignments:

| **Portion** | **Member Allocated** |
|---|---|
| UI / Front-End Design | Steffano Soh |
| Application Developement | Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Zachary J Robicheaux |
| Database Design / Management | Steffano Soh |

# 5. User-Interface Design

The following sections will describe how SchoolBook UI is designed, there will also be an example of User interface flow.

## 5.1 User-Interface Description 
<p align="left">The User Interface is designed to be intuitive and self-explainatory, so it will not confuse users, SchoolBook will consist of 2 very different sets of UI, the introductory UI(public) and the navigation UI(Registered Users), the introductory UI is accessible by the public. In the introductory UI, visitors are able to find out more about what SchoolBook is about, it is also in this page where visitors can register and log in into the SchoolBook system. This UI should look attractive and professional so as to give a good first impression to the visitors, it should also be infomative. The introductory page should be interactive and attractive , at the very top of the page there is a login form followed by a button to toggle the form to a registration form. Next it would display an introduction of SchoolBook and the various social media platform we are on, below there will be screenshots of the navigation UI which is only accessable by registered users, After the screenshots, there would be a counter to show visitors how many student , studet tutors and universities are using SchoolBook, last but not least, at the bottom of the page there will be a get in touch form where users can fill up if they have any questions and it will be sent as an email to the schoolbook email. The navigation UI will be kept as simple as possible as it will provide maximum interactivity and usability to registered users, so there will only be a navigation menu on the right hand side of the page and users can select which functions they would like to perform and the middle of the page would be loaded with forms and information for the user to interact with the server.</p> 

## 5.2 User-Interface Diagrams  
**Introductory View**
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS1.png)
This is the first view of SchoolBook when visitors accesses the webApp. if visitors click on the register button, the register form will show up, this is displayed in the screen below.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS2.png)
When user Scrolls down , the content below the registration / login portion would be the app description and social media links, this is displayed in the screen below.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS3.png)
further down the page would be the screenshots section, this section would display screenshots from the view of a registered user, as of now, the image links are broken as the App is not yet fully developed, once the App is fully developed, the images would be displayed correctly.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS4.png)
Further down the page will display the total numbers of student , tutors & universities that are using SchoolBook.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS5.png)
Lastly at the most bottom of the page, there would be a contact us form which will allow visiotrs to send us an email directly from the webpage.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS6.png)

**Navigation View**
Below would be screenshots of what registered users would see when they log in to SchoolBook, as of now this portion of the application is still under developement, however on log in, every user would have their own spcific welcom messgae and information about their registered course as shown below.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS7.png)
Users can navigate on the left menu portion to perform various system functions.
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/SS8.png)

# 6. Database Design
The following sections below will describe the considerations taken while designing the database SchoolBook, followed by a Database Entity Relation Diagram for SchoolBook in 6.2.

## 6.1 Database Description 
<p> SchoolBook will be using a MySQL Database hosted on a MySQL Server.</p>
<p>The database design for SchoolBook is determined to be mildly complicated, The database is designed in a way that it includes data required to perform functions that are yet to be determined, such as chat history table is created to support chats functionality which is a function yet to be determined.</p>
<p>Every row in a table can be identified by a unique primary key which is a unique attribute to that row of recored, also a compisite key which is a compisition of attributes which permutated would be able to identify a single row of record, being a relational database, the whole designed is normalized to reduce data redundancy, an improve data integrity. Foreign key Contraints are imposed on table attributes which are used to relate one table to another so as to ensure data integrity.</p>
<p>Every relation between tables are described by one to many (1..*) , one to one (1..1) and many to many (*..*), 1..1 relations on both ends of the tables are eliminated as this means that the 2 tables can be combined into one to save resources as having a table with n attributes require less resources compared to having 2 tables with n/2 attributes each and 1..1 relation on both ends means that every row on either side will correspond to one row on the other side.</p>
<p>Database Security is an important factor to take note, currently, when in developement stage, all programmers will access the database as root user but they are encouraged to not alter the database design, if an alteration is require they are to consult the database architect. After developement a seperate Mysql account would be provided for access to the database with different level of permissions assigned to the accounts.</p>

## 6.2 Database ER Diagram 
Below is the Database ER Diagram , Primary key attributes are underlined and foregin key attributes are denoted with (FK) (eg. UniversityID (FK)).
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/Database/SchoolBookER_v1.3.gif)

# 7. Element Catalog
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/View%20Keys.png)
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimages/UIElements.png)
