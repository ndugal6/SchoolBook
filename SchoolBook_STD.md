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

## Login

### Login with Registered Email & Password

|  | |
|----------------------------------- | --------------------------------    |
| **Test Case No. :** TC 1.2.1 | **Test Case Name:** Login With Registered Email & Password  |
| **System:** SchoolBook         | **Sub-System:** Login      |
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
| **System:** SchoolBook         | **Sub-System:** Login      |
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
| **System:** SchoolBook         | **Sub-System:** Login      |
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
| **System:** SchoolBook         | **Sub-System:** Login      |
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
