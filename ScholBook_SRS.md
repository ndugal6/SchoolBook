
# Software Requirements Specification for SchoolBook

**Prepared by:** 

Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao, Steffano, Zachary J Robicheaux

**Date Prepared: 10/19/2016**


| Table of Contents         |
| --- |
| **1. Introduction**                 |
|      1.1        Purpose        |
|      1.2        Document Conventions        |
|      1.3        Intended Audience and Reading Suggestions        |
|      1.4        Product Scope        |
|      1.5        References        |
| **2. Overall Description**   |
|      2.1        Product Perspective        |
|      2.2        Product Functions        |
|      2.3        User Classes and Characteristics        |
|      2.4        Operating Environment        |
|      2.5        Design and Implementation Constraints        |
|      2.6        User Documentation        |
|      2.7        Assumptions and Dependencies        |
| **3. External Interface Requirements** |
|      3.1        User Interfaces        |
|      3.2        Hardware Interfaces        |
|      3.3        Software Interfaces        |
|      3.4        Communications Interfaces        |
| **4. System Features** |
|      4.1.1        Registration       |
|      4.1.2        Login        |
|      4.1.3        Password Reset        |
|      4.2.1        Update Profile        |
|      4.2.2        Add Course        |
|      4.2.3        Register As Tutor        |
|      4.3.1        Create Study Group         |
|      4.3.2        Search for study Group        |
|      4.3.3        Join Study Group        |
|      4.3.4        Leave Study Grp        |
|      4.4.1        Upload Notes        |
|      4.4.2        Search For Notes        |
| **5. Other Non-Functional Requirements** |
|      5.1        Performance Requirements        |
|      5.2        Safety Requirements        |
|      5.3        Security Requirements        |
|      5.4        Software Quality Attributes        |
|      5.5        Business Rules        |
| **Appendix A: Glossary**         |
| **Appendix B: Analysis Models**         |
| **Appendix C: To Be Determined List**         |



Revision History

| Name | Date | Reason For Changes | Version |
| --- | --- | --- | --- |
|   |  |   |   |
|   |  |  |   |


# 1.Introduction

## 1.1Purpose

The product that will have its requirements specified in this document is SchoolBook. This document will be specifying version 1.0 of SchoolBook.

## 1.2Document Conventions

Functional requirements are deonted by FR4.x.x. For example, FR4.4.x are notes management functions.

## 1.3Intended Audience and Reading Suggestions

This document is intended solely for the developers of SchoolBook. It is recommeded that developers read through this doc in order to gain a full understanding of the system. The rest of the document is organized in this respective order: An overall description, external interface requirements, a list and explanation of features, non-functional requirements, and other requirements.

## 1.4Product Scope

SchoolBook was produced to augment the studies of college students. This was done by providing students easy acess to study groups and other students notes.

## 1.5References

There are no documents that this SRS document refers to.

# 2.Overall Description

## 2.1Product Perspective

SchoolBook is a new, self contained product that was developed by a group of LSU Computer Science students.

## 2.2Product Functions

a. Registration - Users register an account to SchoolBook
b. Login - Users enter their email and password to enter the SchoolBook application
c. Password Reset - Users enter their email in order to recieve their new password
d. Update Profile - Users enter/edit their account information after a password prompt
e. Add Course - Users click the add button on a course, which adds said course to the users course list
f. Register as Tutor - During registration a user can choose to be a tutor rather than a student
g. Upload Notes - Users can either drag and drop or browse through their system for notes to upload
h. Search for Notes - Users will enter a keyword, then will be brought to a list of notes that have that keyword
i. Create Study Group - Users enter class, location and meeting times to create a study group
j. Search for Study Group - Users will enter the class number and will be to a list of Study Groups for said class
k. Join Study Group - User is added to a list of users in the study group
l. Leave Study Group - User is removed from the list of users in that study group

## 2.3User Classes and Characteristics

a. User 1 - Tutor
This user will only use SchoolBook when someone requests them as a tutor.

b. User 2 - Avid Student User
This user will use SchoolBook frequently for notes, tutors and/or study groups. 

c. User 3 - Occasional Student User
This user will use SchoolBook on occasion for a multitude of feautures.

## 2.4Operating Environment

Since SchoolBook is a webapp, this application can be used by any OS, as long as the Internet browser is up to date.

## 2.5Design and Implementation Constraints

Due to a relatively development cycle, we are unable to create more diffucult or time constraining features. This includes a chat feature and an iOS/Android application. 

## 2.6User Documentation

There are no user documents currently.

## 2.7Assumptions and Dependencies

It is assumed that all developers will have access to Visual Studios to devolop this application.

# 3.External Interface Requirements

## 3.1User Interfaces

&lt;Describe the logical characteristics of each interface between the software product and the users. This may include sample screen images, any GUI standards or product family style guides that are to be followed, screen layout constraints, standard buttons and functions (e.g., help) that will appear on every screen, keyboard shortcuts, error message display standards, and so on. Define the software components for which a user interface is needed. Details of the user interface design should be documented in a separate user interface specification.&gt;

## 3.2Hardware Interfaces

&lt;Describe the logical and physical characteristics of each interface between the software product and the hardware components of the system. This may include the supported device types, the nature of the data and control interactions between the software and the hardware, and communication protocols to be used.&gt;

## 3.3Software Interfaces

&lt;Describe the connections between this product and other specific software components (name and version), including databases, operating systems, tools, libraries, and integrated commercial components. Identify the data items or messages coming into the system and going out and describe the purpose of each. Describe the services needed and the nature of communications. Refer to documents that describe detailed application programming interface protocols. Identify data that will be shared across software components. If the data sharing mechanism must be implemented in a specific way (for example, use of a global data area in a multitasking operating system), specify this as an implementation constraint.&gt;

## 3.4Communications Interfaces

&lt;Describe the requirements associated with any communications functions required by this product, including e-mail, web browser, network server communications protocols, electronic forms, and so on. Define any pertinent message formatting. Identify any communication standards that will be used, such as FTP or HTTP. Specify any communication security or encryption issues, data transfer rates, and synchronization mechanisms.&gt;

# 4.System Features

&lt;This template illustrates organizing the functional requirements for the product by system features, the major services provided by the product. You may prefer to organize this section by use case, mode of operation, user class, object class, functional hierarchy, or combinations of these, whatever makes the most logical sense for your product.&gt;

## 4.1.1 Registration

a. Description and Priority
Allows new users to register an account with SchoolBook to gain access to the various functions and information available. This Requirement should be of high priority as users would need to have an account before they are able to consume any services from SchoolBook.

b. Stimulus/Response Sequences
  1. User Visits SchoolBook URL www.SchoolBook.com.
  2. System displays introductory page which contains the Registration Button.
  3. User Clicks on the Registration button.
  4. System will respond by displaying the registration form.
  5. User fills up registration form with fields: Email-Address, Password, Confirm Email-Address, Confirm Password, Date of Birth, Full      Name, Gender and University.
  6. User Clicks on register button after form is filled.
  7. System will check input data for error.
  8. System will display success / failure message, a confirmation email will be sent to user upon sucess.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.1.1: Registration |
| **Summary**      | The system should provide a Registration feature to allow users to create an account with SchoolBook |
| **Rational**     | The system will be used to aid students in studying. Thus it is important for students to have an account so that the system will be able to display information of most use to them.|
| **Requirements** | The System should provide a registration form and a submit button for users to enter account details and submit their registration request, System should verify that the account details inserted by the user is in accordance with table REG6.1. Once the user clicks the register button, system will display success message to the user, system will display failure message if data inserted by user is not in accordance with table REG6.1   |
| **References**   | REG6.1: User account data input requirements      |

## 4.1.2 Login

a. Description and Priority
Allows Registered users to gain access to the system. This Requirement should be of high priority as this is the first step a user needs to satisfy before being able to gain access to the services provided by SchoolBook.

b. Stimulus/Response Sequences
  1. User Visits SchoolBook URL www.SchoolBook.com.
  2. System Displays introductory page which contains the Login form.
  3. User keys in Email Address & Password and clicks Login Button.
  4. System compares input values with UserAccounts database table and checks if input data exsists in the database.
  5. System will redirect user to the Login Hompage on sucessful verification.
  6. System will display error message on verification failure.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.1.2: Login |
| **Summary**      | The system should provide a Login feature to allow users to access their account and consume services provided by SchoolBook |
| **Rational**     | The system will need retrieve unique user-specific information from the database so that relevant information can be displayed to the logged-in user.|
| **Requirements** | The System should provide a Login form and a Login button for users to enter account details and submit their Login request, System should verify that the account details inserted by the user Exsists in the SchoolBook Database, Upon sucessful verification, user will be redirected to the user Homepage, upon verification failure, system will display error message   |
| **References**   |  -Nil-    |

## 4.1.3 Password Reset

a. Description and Priority
Allows Registered users to gain access to reset their password in an event that they forgot their password. This Requirement should be of middle priority as this event may not necessary occur.

b. Stimulus/Response Sequences
  1. User Visits SchoolBook URL www.SchoolBook.com.
  2. System Displays introductory page which contains the Forgot Password Link.
  3. User keys in Email Address and clicks Retrieve Button.
  4. System checks if email address exsists in SchoolBook database & if it exsists, sends an email containing a link to user email            account, if email does not exsist, system displays error message.
  5. User accesses email and click on link sent.
  6. System displays Password Reset Page
  7. user keys in new password in accordance to table REG6.1 password field and clickssubmit.
  8. System will display sucess message, update account password and send confirmation email to user email. User will be redirected to        introductory page with Login Form.
  9. if password entered is not in accordance with table REG6.1, system will display error message.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.1.2: Password Reset |
| **Summary**      | The system should provide a Password Reset feature to allow users to Reset their password in any event that they forgot their password. |
| **Rational**     | The System should allow users to reset their password if users forgets it so that user can still keep their accounts with their previous data.|
| **Requirements** | The System should provide a Password Reset form and a Submit button for users to enter new Password and submit their Password Reset request, System should verify that the New Password inserted by the user is in accordance to table REG6.1's password format, if in accordance, system will update account password, display sucess message, send email to user and user will be redirected back to introductory page with Login form, if password is not in accordance, system will display error message.   |
| **References**   |  REG6.1: User account data input requirements   |

## 4.3.1 Create Study Group
a. Description and Priority
The create study group feature will allow users to setup a study group by specifing a location, time, course, and if a tutor will be requested.  Once all study group information is entered correctly the users will be presented with a confirmatoin / failure message and retured to their home screen.

b. Stimulus / Response Sequences
  1. A verified user is successfully logged into the system.
  2. From either the home page menu or a specific course page's menu the user selects the setup study group function.
  3. The system presents the user with the setup study group page.
  4. User specifies what course, location, time, and if they request a tutor or not.
  5. System will check input data for errors.
  6. System will display success / failure message, and returns them to the home screen.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.3.1: Setup Study Group |
| **Summary**      | The system will provide a setup study group feature that will allow students to setup study groups with their classmates. |
| **Rational**     | The system is a way for students to be better connected with their classmates, setting up and attending study groups is an important part of a student’s education. Therefore, it is an important component to this system.  |
| **Requirements** | The user must be successfully logged into the system, and selected setup study group form either the home page menu or the course page's menu.  The system presents the user with a study group setup screen, the user specifies the course, location, time, and whether or not they want a tutor to attend. The system will display a success or failure message after checking the input data.  |
| **References**   |  -Nil-    |

## 4.3.2 Find Study Group
a. Description and Priority
The search for study group feature will allow uses to search for study groups based on the course department and ID.  The system will present the user with a list of the upcoming scheduled study groups for that course.

b. Stimulus / Response Sequences
  1. A verified user is successfully logged into the system.
  2. From either the home page menu or a specific course page menu the user selects the find study group function.
  3. The system presents the user with a find study group screen.
  4. The user specifies the course's department and course ID.
  5. The system displays a list of upcoming scheduled study groups for the specified course and its details.
  6. The user selects a study group from the list.
  7. System displays a screen showing the details of the study group and a join study group option. 

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.3.2: Find Study Group |
| **Summary**      | The system will provide a find study group feature that will allow students to find study goups for the courses they are enrolled in. |
| **Rational**     | The system provides a setup study group function, so the system must include a find study group function for users to find study groups that have already been setup.  |
| **Requirements** | The user must be successfully logged into the system, and selected find study group form either the home page menu or the course page's menu. The user provides a course department and course ID. The system presents the user with a list of upcoming scheduled study groups for the specified course. |
| **References**   |  REG4.3.1: Create Study Group    |

## 4.3.3 Join Study Group
a. Description and priority
The join study group feature will allow users to join study groups from the find study group search results screen.

b. Stimulus / Response Sequences
  1. A verified user has selected a specific study group from the find study group function results.
  2. System displays a screen showing the details of the study group and a join study gruop option.
  3. User selects the join study group option.
  4. System displays a success / failure message and returns the user to the study group's details page.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.3.3: Join Study Group |
| **Summary**      | The system will provide a join study group feature that will allow students to join study groups  for the courses they are enrolled in. |
| **Rational**     | The system provides a setup study group function, so the system should include a join study group function for users to join study groups that have already been setup.  |
| **Requirements** | The user must be successfully logged into the system, and selected join study group form the study group's details page, the system displays a success / failure message and returns the user to the study group's details page. |
| **References**   |  REG4.3.2: Find Study Group    |

## 4.3.4 Leave Study Group
a. Description and priority
The leave study group feature will allow users to leave study groups  that they have previously joined.

b. Stimulus / Response Sequences
  1. A verified user has successfully logged into the system and joined a study group.
  2. The user selects the leave study group feature from the home page menu.
  3. The system displays a list of the study groups that the user has previously joined.
  4. The user selects the study group that they intend to leave from the list.
  5. The system displays a confirmation message asking if the user intends to leave the selected course displaying the study group’s details.
  6. If the user confirms the action the system removes the user from the study group, displays a success / failure message and returns the user to the home page. If the user denies the action the system returns the user back to the list of study groups they can leave without removing the user from the study group.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.3.4: Leave Study Group |
| **Summary**      | The system will provide a leave study group feature that will allow students to leave study groups they have previously joined. |
| **Rational**     | The system provides a setup study group function, and a join study group function, so the system should also provide a leave study group function.  |
| **Requirements** | The user must be successfully logged into the system, have previously used the find and join study group functions to join a study group. The user selects the leave study group function from the home page menu.  The system displays list of the study groups that the user has previously joined. The user selects the study group they wish to leave from the list. The system presents a confirmation message to the user.  If the user confirms the action the user is removed from the study group, the system presents a success / failure message and returns the user to the home page. If the user denies the action the user is not removed from the study group and is returned to the leave study group page containing the list of study groups they have previously joined. |
| **References**   |  REG4.3.3: Join Study Group    |

## 4.4.1 Uploading Notes

a. Description and Priority
Allows users to upload documents, class notes, and study tools for a specific course. Users will be able to access these notes by accessing the course page for which the notes were uploaded for. 

b. Stimulus/Response Sequences
  1. User Visits SchoolBook URL www.SchoolBook.com.
  2. User logs in and accesses student profile.
  3. User is brought to their own personal page if previously registered. 
  4. Select the course and semester/year in which the notes are being used for.
  5. By clicking the upload button, notes are added to the selected course page. 

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.4.1: Uploading Notes |
| **Summary**      | The system provides the user with the ability to add notes for specific courses for a specific semester |
| **Rational**     | The main purpose for 'SchoolBook' is to allow students to access notes and study aids from other students in need of help. In order for students to access notes, an upload feature is needed.|
| **Requirements** | In order for the user to upload notes, the user must first register as a student at a specific university. After registering for SchoolBook, the user will then be able to upload the notes of their choice for the specific course.   |
| **References**   | -Nil-   |

## 4.1.2 Searching for Notes

a. Description and Priority
The search feature will allow students to search and filter throughout the database for specific courses. The search results will allow the user to select that course in which then a list of previously uploaded notes will appear for that specific course. 

b. Stimulus/Response Sequences
  1. User Visits SchoolBook URL www.SchoolBook.com.
  2. User logs in and accesses student profile.
  3. User is brought to their own personal page if previously registered. 
  4. The top bar of the main page will provide users with a search bar.
  5. By typing into the search bar, results will reveal a list of courses throughout the database.
  6. By selecting a course in the list, the user will be provided with a list of previously uploaded notes for that specific course.

c. Functional Requirements

| **Title**        |  **Description** |
|  ----            |     -----               |
| **Item**         |  FR-4.4.2: Searching for Notes |
| **Summary**      | The system will provide users with the ability to search for courses throughout the database and select from a list of list of previously uploaded documents |
| **Rational**     | The search bar is used to search for courses offered at the University, therefore the user must search for a valid course in order to access notes. |
| **Requirements** | The user must search for a course offered at the University of their choice in order to access notes.  |
| **References**   |  -Nil-    |


# 5.Other Nonfunctional Requirements

## 5.1Performance Requirements

&lt;If there are performance requirements for the product under various circumstances, state them here and explain their rationale, to help the developers understand the intent and make suitable design choices. Specify the timing relationships for real time systems. Make such requirements as specific as possible. You may need to state performance requirements for individual functional requirements or features.&gt;

## 5.2Safety Requirements

&lt;Specify those requirements that are concerned with possible loss, damage, or harm that could result from the use of the product. Define any safeguards or actions that must be taken, as well as actions that must be prevented. Refer to any external policies or regulations that state safety issues that affect the product&#39;s design or use. Define any safety certifications that must be satisfied.&gt;

## 5.3Security Requirements

&lt;Specify any requirements regarding security or privacy issues surrounding use of the product or protection of the data used or created by the product. Define any user identity authentication requirements. Refer to any external policies or regulations containing security issues that affect the product. Define any security or privacy certifications that must be satisfied.&gt;

## 5.4Software Quality Attributes

&lt;Specify any additional quality characteristics for the product that will be important to either the customers or the developers. Some to consider are: adaptability, availability, correctness, flexibility, interoperability, maintainability, portability, reliability, reusability, robustness, testability, and usability. Write these to be specific, quantitative, and verifiable when possible. At the least, clarify the relative preferences for various attributes, such as ease of use over ease of learning.&gt;

## 5.5Business Rules

&lt;List any operating principles about the product, such as which individuals or roles can perform which functions under specific circumstances. These are not functional requirements in themselves, but they may imply certain functional requirements to enforce the rules.&gt;

# 6.Other Requirements

## REG6.1 - User account data input requirements
| Field Name            | Requirements                                                                                      | 
| ---                   | ---                                                                                               |
| E-Mail Address        | Characters in the format of xxxxxx@xxxxx.xx (x == charcters)                                      |
| Password              | minimum of 12 alphanumeric characters, compulsory use of a number and a alphabet                  |
| Confirm Email-Address | Must be exactly the same a what was entered in E-Mail Address field                               |
| Confirm Password      | Must be exactly the same as what was entered in password field                                    |
| Date of Birth         | entered in the formac of MM/DD/YYYY, The value entered must be of a valid Gregorian calendar date |
| Full Name             | Maximum of 40 characters                                                                          |
| Gender                | Radio Button, with display value of Male & Female, only able to select one                        |
| University            | Drop-down list of all the available universities, user only able to select one                    |

&lt;Define any other requirements not covered elsewhere in the SRS. This might include database requirements, internationalization requirements, legal requirements, reuse objectives for the project, and so on. Add any new sections that are pertinent to the project.&gt;

Appendix A: Glossary

&lt;Define all the terms necessary to properly interpret the SRS, including acronyms and abbreviations. You may wish to build a separate glossary that spans multiple projects or the entire organization, and just include terms specific to a single project in each SRS.&gt;

# Appendix B: Analysis Models

## Use-Case Diagram
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimgs/SchoolBookUseCaseDiagram.gif)

## Entity-Relation Diagram
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimgs/ERDiagramSchoolBook.gif)

## Tutor Application Dataflow Diagram
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/SRSimgs/SB_TUTORAPP_DF.gif)

## Database ER Diagram
![alt tag](https://raw.githubusercontent.com/ndugal6/SchoolBook/master/Database/SchoolBookERv1.2.gif)


&lt;Optionally, include any pertinent analysis models, such as data flow diagrams, class diagrams, state-transition diagrams, or entity-relationship diagrams.&gt;

Appendix C: To Be Determined List

&lt;Collect a numbered list of the TBD (to be determined) references that remain in the SRS so they can be tracked to closure.&gt;
