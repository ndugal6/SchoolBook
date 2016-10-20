
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
|  Steffano Soh | 10/19/2016  | document template Creation  | 1.0  |
|   |   |   |   |



# 1.Introduction

## 1.1Purpose

&lt;Identify the product whose software requirements are specified in this document, including the revision or release number. Describe the scope of the product that is covered by this SRS, particularly if this SRS describes only part of the system or a single subsystem.&gt;

## 1.2Document Conventions

&lt;Describe any standards or typographical conventions that were followed when writing this SRS, such as fonts or highlighting that have special significance. For example, state whether priorities  for higher-level requirements are assumed to be inherited by detailed requirements, or whether every requirement statement is to have its own priority.&gt;

## 1.3Intended Audience and Reading Suggestions

&lt;Describe the different types of reader that the document is intended for, such as developers, project managers, marketing staff, users, testers, and documentation writers. Describe what the rest of this SRS contains and how it is organized. Suggest a sequence for reading the document, beginning with the overview sections and proceeding through the sections that are most pertinent to each reader type.&gt;

## 1.4Product Scope

&lt;Provide a short description of the software being specified and its purpose, including relevant benefits, objectives, and goals. Relate the software to corporate goals or business strategies. If a separate vision and scope document is available, refer to it rather than duplicating its contents here.&gt;

## 1.5References

&lt;List any other documents or Web addresses to which this SRS refers. These may include user interface style guides, contracts, standards, system requirements specifications, use case documents, or a vision and scope document. Provide enough information so that the reader could access a copy of each reference, including title, author, version number, date, and source or location.&gt;

# 2.Overall Description

## 2.1Product Perspective

&lt;Describe the context and origin of the product being specified in this SRS. For example, state whether this product is a follow-on member of a product family, a replacement for certain existing systems, or a new, self-contained product. If the SRS defines a component of a larger system, relate the requirements of the larger system to the functionality of this software and identify interfaces between the two. A simple diagram that shows the major components of the overall system, subsystem interconnections, and external interfaces can be helpful.&gt;

## 2.2Product Functions

&lt;Summarize the major functions the product must perform or must let the user perform. Details will be provided in Section 3, so only a high level summary (such as a bullet list) is needed here. Organize the functions to make them understandable to any reader of the SRS. A picture of the major groups of related requirements and how they relate, such as a top level data flow diagram or object class diagram, is often effective.&gt;

## 2.3User Classes and Characteristics

&lt;Identify the various user classes that you anticipate will use this product. User classes may be differentiated based on frequency of use, subset of product functions used, technical expertise, security or privilege levels, educational level, or experience. Describe the pertinent characteristics of each user class. Certain requirements may pertain only to certain user classes. Distinguish the most important user classes for this product from those who are less important to satisfy.&gt;

## 2.4Operating Environment

&lt;Describe the environment in which the software will operate, including the hardware platform, operating system and versions, and any other software components or applications with which it must peacefully coexist.&gt;

## 2.5Design and Implementation Constraints
School book == webapp on asp.net 4.0
&lt;Describe any items or issues that will limit the options available to the developers. These might include: corporate or regulatory policies; hardware limitations (timing requirements, memory requirements); interfaces to other applications; specific technologies, tools, and databases to be used; parallel operations; language requirements; communications protocols; security considerations; design conventions or programming standards (for example, if the customer&#39;s organization will be responsible for maintaining the delivered software).&gt;

## 2.6User Documentation

&lt;List the user documentation components (such as user manuals, on-line help, and tutorials) that will be delivered along with the software. Identify any known user documentation delivery formats or standards.&gt;

## 2.7Assumptions and Dependencies

&lt;List any assumed factors (as opposed to known facts) that could affect the requirements stated in the SRS. These could include third-party or commercial components that you plan to use, issues around the development or operating environment, or constraints. The project could be affected if these assumptions are incorrect, are not shared, or change. Also identify any dependencies the project has on external factors, such as software components that you intend to reuse from another project, unless they are already documented elsewhere (for example, in the vision and scope document or the project plan).&gt;

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

Appendix B: Analysis Models

&lt;Optionally, include any pertinent analysis models, such as data flow diagrams, class diagrams, state-transition diagrams, or entity-relationship diagrams.&gt;

Appendix C: To Be Determined List

&lt;Collect a numbered list of the TBD (to be determined) references that remain in the SRS so they can be tracked to closure.&gt;
