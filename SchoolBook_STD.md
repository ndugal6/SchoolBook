# Software Testing Document for SchoolBook

**Prepared by:** 

Clayton R Samson, Justin A Bougere, Nicholas A Dugal, Sean M Marino, Soh Guo Hao Steffano, Zachary J Robicheaux

**Date Prepared: 11/14/2016**


| Table of Contents         |
| --- |
| **1. Login/Registration** |
|      TC 1.1        Registration       |
|      TC 1.2        Login        |
|      TC 1.3        Password Reset        |
| **2. Profile Management** |
|      TC 2.1        Update Profile        |
|      TC 2.2        Add Course        |
|      TC 2.3        Register as Tutor        |
| **3. Study Group Management** |
|      TC 3.1        Create Study Group         |
|      TC 3.2        Search for study Group        |
|      TC 3.3        Join Study Group        |
|      TC 3.4        Leave Study Group        |
| **4. Notes Management** |
|      TC 4.1        Upload Notes        |
|      TC 4.2        Search for Notes        |

## Registration
### Registration with satisfied Validation
|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.1.1 | **Test Case Name:** Registration with satisfied Validation  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test the registration system with satisfactory input
<br/>**Pre-Conditions:**
User Must not be already registered <br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Click on the *Register* Button within the Login form section | System changes login form into Registration Form|||
|2.        | Key in __Test2@gmail.com__ in the *Email Address* Text field| -Nil- |||
|3.        | Key in __password1__ in the *Password* Text field| -Nil- |||
|4.        | Key in __Test2@gmail.com__ in the *Confirm Email Address* Text field| -Nil- |||
|5.        | Key in __password1__ in the *Confirm Password* Text field| -Nil- |||
|6.        | Key in __01/01/1990__ in the *Date of Birth* Text field| -Nil- |||
|7.        | Key in __Tom Riddle__ in the *Full Name* Text field| -Nil- |||
|8.        | Select __male__ radio button | -Nil- |||
|9.        | Select __Louisiana State University__ from the drop down list | -Nil- |||
|10.       | Click on the *Register* Button | System Displays Registration sucessful message. |||

**Post Condition:**<br/>
User is sucessfully registered <br/>
User account information now inserted into SchoolBook Database

### Registration with unsatisfactory Validation

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.1.2 | **Test Case Name:** Registration with unsatisfactory Validation  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test the registration system with unsatisfactory input
<br/>**Pre-Conditions:**
User Must not be already registered <br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Click on the *Register* Button within the Login form section | System changes login form into Registration Form|||
|2.        | Key in __Test2__ in the *Email Address* Text field| -Nil- |||
|3.        | Key in __password__ in the *Password* Text field| -Nil- |||
|4.        | Key in __Test3__ in the *Confirm Email Address* Text field| -Nil- |||
|5.        | Key in __password1__ in the *Confirm Password* Text field| -Nil- |||
|6.        | Key in __01/01/1990__ in the *Date of Birth* Text field| -Nil- |||
|7.        | Key in __Tom Riddle__ in the *Full Name* Text field| -Nil- |||
|8.        | do not select any radio button | -Nil- |||
|9.        | do not select any drop down list value | -Nil- |||
|10.       | Click on the *Register* Button | System Displays error message shown in the block below |||

> Please enter a valid email address <br/>
> Please enter a valid password that consist of a mixture of alphaberts and numbers <br/>
> confirm email did not match <br/>
> confirm password did not match <br/>
> Please select your gender <br/>
> Please select a university 

**Post Condition:**<br/>
User account not registered <br/>
User remains in Introductory page

### Registration with Email Address already registered 
|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.1.3 | **Test Case Name:** Registration with Email Address already registered   |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test the registration system with satisfactory Email Address already registered
<br/>**Pre-Conditions:**
-Nil- <br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Click on the *Register* Button within the Login form section | System changes login form into Registration Form|||
|2.        | Key in __Test@gmail.com__ in the *Email Address* Text field| -Nil- |||
|3.        | Key in __password1__ in the *Password* Text field| -Nil- |||
|4.        | Key in __Test@gmail.com__ in the *Confirm Email Address* Text field| -Nil- |||
|5.        | Key in __password1__ in the *Confirm Password* Text field| -Nil- |||
|6.        | Key in __01/01/1990__ in the *Date of Birth* Text field| -Nil- |||
|7.        | Key in __Tom Riddle__ in the *Full Name* Text field| -Nil- |||
|8.        | Select __male__ radio button | -Nil- |||
|9.        | Select __Louisiana State University__ from the drop down list | -Nil- |||
|10.       | Click on the *Register* Button | System Displays "Email Address already Registered" Message |||

**Post Condition:**<br/>
User is sucessfully registered <br/>
User account information now inserted into SchoolBook Database

## Login

### Login with Registered Email & Password

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.2.1 | **Test Case Name:** Login With Registered Email & Password  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016     |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test The Login Sub System with a Registered Email & Password<br/>
<br/>**Pre-Conditions:**
User Must have a Registered Account with SchoolBook<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Key in __Test@gmail.com__ in the *Email Address* Text box within the Login Form | -Nil-|||
|2.        | Key in __password__ in the *Password* Text box within the Login Form | -Nil-|||
|3.        | Click on the *Login* Button within the Login Form | System Redirects user to his Profile Homepage | |

**Post Condition:**<br/>
1. User is logged into the SchoolBook System<br/>
2. User sees his information in the redirected page.

### Login with invalid Email & Password

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.2.2 | **Test Case Name:** Login With invalid Email & Password  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016     |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test The Login Sub System with a invalid Email & Password <br/>
<br/>**Pre-Conditions:**
-Nil-<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Key in __invalid@gmail.com__ in the *Email Address* Text box within the Login Form | -Nil-|||
|2.        | Key in __invalidpassword__ in the *Password* Text box within the Login Form | -Nil-|||
|3.        | Click on the *Login* Button within the Login Form | System displays "incorrect Userid/Password" Message | |

**Post Condition:**<br/>
1. User denied access to SchoolBook<br/>
2. User stays in introductory page.


### Login with valid Email & invalid Password

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.2.3 | **Test Case Name:** Login with valid Email & invalid Password  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016     |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test The Login Sub System with valid Email & invalid Password<br/>
<br/>**Pre-Conditions:**
-Nil-<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Key in __Test@gmail.com__ in the *Email Address* Text box within the Login Form | -Nil-|||
|2.        | Key in __invalidpassword__ in the *Password* Text box within the Login Form | -Nil-|||
|3.        | Click on the *Login* Button within the Login Form | System displays "incorrect Userid/Password" Message | |

**Post Condition:**<br/>
1. User denied access to SchoolBook<br/>
2. User stays in introductory page.


### Login with invalid Email & valid Password

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.2.4 | **Test Case Name:** Login with invalid Email & valid Password  |
| **System:** SchoolBook         | **Sub-System:** Login/Registration      |
| **Designed By:** Steffano Soh    |  **Design Date:** 11/18/2016     |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
Test The Login Sub System with invalid Email & valid Password <br/>
<br/>**Pre-Conditions:**
-Nil-<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.        | Key in __invalid@gmail.com__ in the *Email Address* Text box within the Login Form | -Nil-|||
|2.        | Key in __password__  in the *Password* Text box within the Login Form | -Nil-|||
|3.        | Click on the *Login* Button within the Login Form | System displays "incorrect Userid/Password" Message | |

**Post Condition:**<br/>
1. User denied access to SchoolBook<br/>
2. User stays in introductory page.

## Password Reset

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Update Profile


|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Add Course

## Add Course with Valid Class
|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** tc 1.5.1 | **Test Case Name:**   |
| **System:** SchoolBook        | **Sub-System:**   Add Course with Valid Class  |
| **Designed By:** Zachary Robicheaux    |  **Design Date:** TBD    |
| **Executed By:** Zachary Robicheaux    |  **Execution Date:** TBD |

**Short Description:** <br/>
Test the add course subsystem using valid class selection.
<br/>**Pre-Conditions:**
1. User has a valid account.
<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|Click "Add Course" on the Homepage.|User is taken to the Add Course page; page displays all classes from the user's university|||
|2.|Select the course labeled "test"|-Nil-|||
|3.|Click the "Add Course" button|System displays "course added" Message|||

**Post Condition:**<br/>
1. "test" is added to the user's list of classes
2. The page is refreshed.

## Add Course that User is Enrolled in
|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** tc 1.5.2 | **Test Case Name:**   |
| **System:** SchoolBook        | **Sub-System:**   Add Course that User is Enrolled in  |
| **Designed By:** Zachary Robicheaux    |  **Design Date:** TBD    |
| **Executed By:** Zachary Robicheaux    |  **Execution Date:** TBD |

**Short Description:** <br/>
Test the add course subsystem using a class the user is already enrolled in.
<br/>**Pre-Conditions:**
1. User has a valid account.
2. User is enrolled in class "test" 
<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|Click "Add Course" on the Homepage.|User is taken to the Add Course page; page displays all classes from the user's university|||
|2.|Select the course labeled "test"|-Nil-|||
|3.|Click the "Add Course" button|System displays "already enrolled in class" Message|||

**Post Condition:**<br/>
1. The page is refreshed.


## Register as Tutor

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Create Study Group

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>



## Search for study Group  

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Join Study Group

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>



## Leave Study Group

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Upload Notes

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>


## Search for Notes

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** *CONTENT HERE* | **Test Case Name:** *CONTENT HERE*  |
| **System:** *CONTENT HERE*         | **Sub-System:** *CONTENT HERE*      |
| **Designed By:** *CONTENT HERE*    |  **Design Date:** *CONTENT HERE*    |
| **Executed By:** *CONTENT HERE*    |  **Execution Date:** *CONTENT HERE* |

**Short Description:** <br/>
*CONTENT HERE*
<br/>**Pre-Conditions:**
*CONTENT HERE*<br/>

| **Step** | **Actions** | **Expected System Response** | **Pass/Fail** | **Comments**|
| ---------| ------------| -----------------------------| --------------| ------------|
|1.|||||
|2.|||||

**Post Condition:**<br/>
