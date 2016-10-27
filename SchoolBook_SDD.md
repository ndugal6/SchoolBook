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
|      2.4        Study Groups<br/> &nbsp;&nbsp; 2.4.1     Create Study Group<br/> &nbsp;&nbsp; 2.4.2     Search for study Group<br/> &nbsp;&nbsp; 2.4.3     Join Study Group<br/> &nbsp;&nbsp; 2.4.4     Leave Study Group        |
|      2.5        Notes<br/> &nbsp;&nbsp; 2.5.1    Upload Notes<br/> &nbsp;&nbsp; 2.5.2     Search for Notes        |
| **3. Techinical System Architecture** |
|      3.1        Overview        |
|      3.2        Accounts <br/> &nbsp;&nbsp; 3.2.1     Registration<br/> &nbsp;&nbsp; 3.2.2     Login<br/> &nbsp;&nbsp; 3.2.3     Password Reset|   
|      3.3        Profiles<br/> &nbsp;&nbsp; 3.3.1     Update Profile<br/> &nbsp;&nbsp; 3.3.2     Add Course<br/> &nbsp;&nbsp; 3.3.3     Register as Tutor        |
|      3.4        Study Groups<br/> &nbsp;&nbsp; 3.4.1     Create Study Group<br/> &nbsp;&nbsp; 3.4.2     Search for study Group<br/> &nbsp;&nbsp; 3.4.3     Join Study Group<br/> &nbsp;&nbsp; 3.4.4     Leave Study Group        |
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
*Content Here*

##  2.2 Accounts

###  2.2.1 Registration
*Content Here*

###  2.2.2 Login
*Content Here*

###  2.2.3 Password Reset
*Content Here*

##  2.3 Profile

###  2.3.1 Update Profile
*Content Here*

### 2.3.2 Add Course
*Content Here*

### 2.3.3 Register as Tutor
*COntent Here*

## 2.4 Study Groups

### 2.4.1 Create Study Group
*Content Here*

### 2.4.2 Search for study Group
*Content Here*

### 2.4.3 Join Study Group
*Content Here*

### 2.4.4 Leave Study Group
*Content Here*

## 2.5 Notes

### 2.5.1 Upload Notes
*Content Here*

### 2.5.2 Search For Notes
*Content Here*

# 3. Techinical System Architecture

## 3.1 Overview
*Content Here*

##  3.2 Accounts

###  3.2.1 Registration
*Content Here*

###  3.2.2 Login
*Content Here*

###  3.2.3 Password Reset
*Content Here*

##  3.3 Profile

###  3.3.1 Update Profile
*Content Here*

### 3.3.2 Add Course
*Content Here*

### 3.3.3 Register as Tutor
*COntent Here*

## 3.4 Study Groups

### 3.4.1 Create Study Group
*Content Here*

### 3.4.2 Search for study Group
*Content Here*

### 3.4.3 Join Study Group
*Content Here*

### 3.4.4 Leave Study Group
*Content Here*

## 3.5 Notes

### 3.5.1 Upload Notes
*Content Here*

### 3.5.2 Search For Notes
*Content Here*

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

## 6.1 Database Description 
*Content Here*

## 6.2 Database ER Diagram 
*Content Here*

# 7. Elemnt Catalog
