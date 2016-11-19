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
*CONTENT HERE*<br/>

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
*CONTENT HERE*<br/>

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
