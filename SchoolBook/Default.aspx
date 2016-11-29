<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchoolBook.Default"  EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>SchoolBook</title>
   
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/animated.css" rel="stylesheet" type="text/css" />
    <link href="css/vegas.min.css" rel="stylesheet" type="text/css" />
    <link href="css/owl.carousel.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400italic,700italic,400,700"
        rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script>
       $(document).ready(function () {
        var flag = "reg";
        var flag2 = "forget";
        var loginlbl = document.getElementById("Loginlbl");
        var reglbl = document.getElementById("regBtn");
        $("#FgtpwCancel").hide();
        $("#rtrpw").hide();
        $("#regDiv").hide();
        $("#fgtmsg").hide();
        $("#regBtn").click(function () {
            $("#regDiv").toggle(1000);
            if (flag == "reg") {
                $("#forgetpasslink").hide();
                loginlbl.innerHTML = "Register";
                reglbl.innerHTML = "<i class='fa fa-navicon'></i>Cancel";
                flag = "cancel";
                document.getElementById("loginBtn1").style.display = "none";
            }
            else {
                $("#forgetpasslink").toggle(1000);
                loginlbl.innerHTML = "Login";
                reglbl.innerHTML = "<i class='fa fa-navicon'></i>Register";
                flag = "reg";
                document.getElementById("loginBtn1").style.display = "";
            }
        });

        $("#forgetpasslink").click(function () {
                $("#fgtmsg").toggle(1000);
                $("#rtrpw").toggle(1000);
                $("#FgtpwCancel").toggle(1000);
                $("#forgetpasslink").hide();
                $("#formpassword").hide();
                $("#regBtn").hide();
                loginlbl.innerHTML = "Forget Password";
                flag = "cancel";
                document.getElementById("loginBtn1").style.display = "none";
                document.getElementById("fgtmsg").style.visibility = "visible";
        });

});
</script>

</head>
    
<body class="menu-hide-page">
    

    <form id="form1" runat="server">

    <div id="navigation" class="menu-hide">
         <div class="navbar navbar-fixed-top" role="banner">
            <div class="container">
               <div class="navbar-header"><button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><spanclass="icon-bar"></span><span class="icon-bar"></span></button><a class="navbar-brand" href="index.aspx"><img class="img-responsive" src="img/SB_logo.jpg"></a></div>
               <nav id="main-menu" class="collapse navbar-collapse navbar-right">
                  <ul class="nav navbar-nav">
                     <li class="active"><a href="#navigation">Home</a></li>
                     <li><a href="#features">Features</a></li>
                     <li><a href="#description">App Info</a></li>
                     <li><a href="#screenshots">ScreenShots</a></li>
                     <li><a href="#contact">Contact</a></li>
                    
                  </ul>
               </nav>
            </div>
         </div>
      </div>
      <header class="home padding-150" id="header">
         <div class="container">
            <div class="row">
               <div class="col-md-8">
                  <div class="main-content text-left">
                     <h1 class="section-title">BEST WAY TO GRADUATE!</h1>
                     <h4 class="section-sub-title">Redefining interactive studying</h4>
                     <a href="#" class="btn btn-border"><i class="fa fa-mail-forward"></i>Features</a>
                  </div>
               </div>

               <div class="col-md-4">
                  <div class="panel panel-default black">
                     <div class="panel-heading">
                        <h3 class="panel-title">SchoolBook - <span id="Loginlbl">Login</span></h3>
                     </div>
                     <div class="panel-body black">
                        <form role="form">
                           <div class="form-group">
                               <input type="email" name="email" id="email" runat="server" class="form-control input-sm" placeholder="Email Address" />

                           </div>
                           <div class="row">
                              <div class="col-xs-12 col-sm-12 col-md-12">
                                 <div class="form-group">
                                     <input type="password" name="password" id="formpassword" runat="server" class="form-control input-sm" placeholder="Password" /></div>
                                    <a href="#" id="forgetpasslink" style="color:red">Forget Password?</a>
                                    <p id="fgtmsg" style="color:white;">Please Enter your registered email, we will send a an email containing password reset instructions!</p>
                                    <a href="#" id="rtrpw" class="btn btn-border" runat="server" onserverclick="forgetpass_click"><i class="fa fa-user"></i>Retrieve</a>
                                    <a href="#" id="FgtpwCancel" class="btn btn-border" runat="server" onserverclick="forgetpasscancel_click"><i class="fa fa-user"></i>Cancel</a>
                              </div>
                             
                           
                                   
                              <div class="col-xs-12 col-sm-12 col-md-12" id="regDiv">
                                   <div class="form-group">
                                       <input type="email" name="email" id="regcfmemail" runat="server" class="form-control input-sm" placeholder="Confirm Email" /><br />
                                       <input type="password" name="password" id="regcfmpassword" runat="server" class="form-control input-sm" placeholder="Confirm password" /><br />
                                       <input id="DobInput" runat="server" class="form-control input-sm" placeholder="Date of Birth(MM/DD/YYYY)" /><br />
                                       <input id="regFullName" runat="server" class="form-control input-sm" placeholder="Full Name" /><br />

                                       <div style="align-self:flex-end">
                                       <input type="radio" name="gender" value="Male" id="regMale" runat="server"/> <span style="color:white">Male</span> 
                                       &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                       <input type="radio" name="gender" value="Female" id="regFemale" runat="server" /> <span style="color:white">Female</span> <br /><br />

                                       <select class="form-control input-sm" runat="server" id="regUni">
                                        <option value="" disabled selected style="display: none;">University</option>
                                        <option value="Louisiana State University">Louisiana State University (LSU)</option>
                                       </select><br />

                                        <a href="#" id="regRegBtn" class="btn btn-border" runat="server" onserverclick="Reg_Click"><i class="fa fa-user"></i>Register!</a>
                                       </div>
                                   </div>
                                </div>
                               

                              <div><p id="loginstatuslbl" style="color:red" runat="server"></p></div>
                           </div>
                        </form>
                        
                     </div>
                      
                     <div class="panel-footer"><a href="#" class="btn btn-border" runat="server" onserverclick="login_Click" id="loginBtn1"><i class="fa fa-user"></i>Log-In</a><a href="#register" id="regBtn" class="btn btn-border" runat="server"><i class="fa fa-navicon"></i> Register</a></div>
                  
                  </div>

                   <div style="height:135px"></div>
               
                
            </div>

         </div>
         <div id="copyright-header">
            <div class="container">
               <div id="social">
                  <ul class="list">
                     <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                     <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                     <li><a href="#"><i class="fa fa-dribbble"></i></a></li>
                     <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                     <li><a href="#"><i class="fa fa-instagram"></i></a></li>
                  </ul>
               </div>
            </div>
         </div>
      </header>

      <div id="features">
         <div class="padding-100">
            <div class="container">
               <div class="col-md-12">
                  <div class="row">
                     <h3 class="h1 col-sm-5 blue"><span class="underline">Welcome</span> to SchoolBook</h3>
                     <div class="col-sm-8">
                        <h4 class="h2">Introduction Here</h4>
                        <ul class="horizontalLinks">
                           <li><i class="fa fa-long-arrow-right"></i><a href="#" class="arrowLink arrowRight"title="" target="_self">Learn more about us</a></li>
                           <li><i class="fa fa-long-arrow-right"></i><a href="#" class="arrowLink arrowRight" title="" target="_self">Work with us</a></li>
                        </ul>
                     </div>
                  </div>
               </div>
            </div>
            <div class="text-center">
               <div class="container padding-40">
                  <div id="features-slider">
                      <div class="item">
                        <img class="img-responsive" src="img/features/android.png" alt=""/>
                        <h2>Cooming Soon</h2>
                        <p>SchoolBook Android & iOS will be comming soon</p>
                     </div>
                     <div class="item">
                        <img class="img-responsive" src="img/features/feature2.png" alt=""/>
                        <h2>Responsive Design</h2>
                        <p>View SchoolBook is now compatible with tablets and mobile web browsers!</p>
                     </div>
                      <div class="item">
                        <img class="img-responsive" src="img/features/feature1.png" alt=""/>
                        <h2>Follow us on twitter!</h2>
                        <p>Follow us on twitter to get the latest schoolbook updates!</p>
                     </div>
                     <div class="item">
                        <img class="img-responsive" src="img/features/youtube.png" alt=""/>
                        <h2>Video Tutorials</h2>
                        <p>Find video tutorials on how to use SchoolBook on youtube!</p>
                     </div>
                     <div class="item">
                        <img class="img-responsive" src="img/features/Facebook.png" alt=""/>
                        <h2>Like us on Facebook!</h2>
                        <p>Like us on facebook to recieve the latest schoolbook news!</p>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>



      <div id="description">
         <div class="container">
            <div class="description-section padding-100">
               <div class="row">
                  <div class="col-md-12">
                     <div class="row">
                        <h3 class="h1 col-sm-4 blue"><span class="underline">Description</span> about app</h3>
                        <div class="col-sm-8">
                           <h4 class="h2">School Book web app description</h4>
                           <div class="horizontalLinks padding-bottom-40"><a href="#" class="btn btn-common"><i class="fa fa-long-arrow-right"></i>Work with us</a></div>
                        </div>
                     </div>
                  </div>
                  <div class="col-sm-6">
                     <div class="descriptions">
                        <div class="description">
                           <i class="fa fa-paper-plane"></i>
                           <p>Find classmates who are in the same courses as you!</p>
                        </div>
                        <div class="description">
                           <i class="fa fa-life-ring"></i>
                           <p>A platform to interact and exchange information with students who are studying the same course as you!</p>
                        </div>
                        <div class="description">
                           <i class="fa fa-pagelines"></i>
                           <p>Form Study groups or find tutors! easy way to meet up and study to gain academic advantage!</p>
                        </div>
                        <div class="description">
                           <i class="fa fa-music"></i>
                           <p>Find course notes uploaded by previous students!</p>
                        </div>
                        <div class="description">
                           <i class="fa fa-paper-plane"></i>
                           <p>Earn some extra cash by teaching others subjects you are good at!</p>
                        </div>
                     </div>
                  </div>
                  <div class="col-sm-6 text-center"><img class="img-responsive" alt="Screenshots of school book"/></div>
               </div>
            </div>
         </div>
      </div>
    
      <div id="screenshots">
         <div class="overlay-bg"></div>
         <div class="container">
            <div class="padding-100">
               <div class="row">
                  <h3 class="h1 col-sm-4 blue"><span class="underline">Screenshots</span></h3>
                  <div class="col-sm-8">
                     <h4 class="h2">ScreenShot description of SchoolBook</h4>
                     <a href="#" class="btn btn-common"><i class="fa fa-long-arrow-right"></i>Learn moreabout us</a><a href="#" class="btn btn-common"><i class="fa fa-long-arrow-right"></i>Work with us</a>
                  </div>
               </div>
               <div id="screenshot-slider" class="padding-50">
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss1.jpg" alt="SS1"/></div>
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss2.jpg" alt="SS2"/></div>
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss3.jpg" alt="SS3"/></div>
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss4.jpg" alt="SS4"/></div>
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss5.jpg" alt="SS5"/></div>
                  <div class="item"><img class="img-responsive" src="img/screenshots/ss6.jpg" alt="SS6"/></div>
               </div>
            </div>
         </div>
      </div>
      <section id="about" class="smoke-bg padding-50">
         <div class="container">
            <div class="row divide-md counter-section">
               <div class="col-sm-4 col-xs-6 divide-md">
                  <div class="counter" id="counter-1"></div>
                  <h4>Students</h4>
               </div>
               <div class="col-sm-4 col-xs-6 divide-md">
                  <div class="counter" id="counter-2"></div>
                  <h4>Tutors</h4>
               </div>
               <div class="col-sm-4 col-xs-6 divide-md">
                  <div class="counter" id="counter-3"></div>
                  <h4>Universities</h4>
               </div>
              
            </div>
         </div>
      </section>
      <section id="contact" class="white-bg">
         <div class="container padding-100">
            <div class="row">
               <div class="section-header wow zoomIn animated" data-wow-offset="10" data-wow-delay="0.5s">
                  <h3 class="h1 blue"><span class="underline">Get</span> In-Touch</h3>
               </div>
            </div>
            <div class="row padding-top-40">
               <div class="col-md-8">
                  <div id="main-contact-form" class="contact-form">
                     <form role="form" action="contact.php" method="post">
                        <div class="form-group"><label class="sr-only" for="contact-name"> Name</label><input type="text" name="name" placeholder="Name..." class="contact-name form-control" id="contact-name"></div>
                        <div class="form-group"><label class="sr-only" for="contact-email"> Email</label><input type="text" name="email" placeholder="Email..." class="contact-email form-control" id="contact-email"></div>
                        <div class="form-group"><label class="sr-only" for="contact-subject"> Subject</label><input type="text" name="subject" placeholder="Subject..." class="contact-subject form-control" id="contact-subject"></div>
                        <div class="form-group"><label class="sr-only" for="contact-message"> Message</label><textarea name="message" placeholder="Message..." class="contact-message form-control" id="contact-message"></textarea></div>
                        <button type="submit" class="btn btn-common"> Send message</button>
                     </form>
                  </div>
               </div>
               <div class="col-md-4">
                  <h4 class="column-title"><span>Information</span></h4>
                  <p> School book info. </p>
                  <div style="margin-bottom: 10px;"></div>
                  <div style="margin-bottom: 30px;"></div>
                  <h4 class="column-title"><span>Working Hours</span></h4>
                  <ul class="list-unstyled">
                     <li><strong>Monday - Friday</strong> - 9am to 5pm</li>
                     <li><strong>Saturday</strong> - 9am to 2pm</li>
                     <li><strong>Sunday</strong> - Closed</li>
                  </ul>
               </div>
            </div>
         </div>
      </section>
      <footer>
         <div class="container">
            <div class="row footer-widgets">
               <div class="col-md-9 col-xs-12">
                  <div class="footer-widget mail-subscribe-widget social-widget wow zoomIn animated" data-wow-offset="10" data-wow-delay="0.5s">
                     <h4> Follow Us<span class="head-line"></span></h4>
                     <ul class="social-icons">
                        <li><a class="facebook" href="#"><i class="fa fa-facebook"></i></a></li>
                        <li><a class="twitter" href="#"><i class="fa fa-twitter"></i></a></li>
                        <li><a class="google" href="#"><i class="fa fa-google-plus"></i></a></li>
                        <li><a class="dribbble" href="#"><i class="fa fa-dribbble"></i></a></li>
                        <li><a class="linkdin" href="#"><i class="fa fa-linkedin"></i></a></li>
                        <li><a class="flickr" href="#"><i class="fa fa-flickr"></i></a></li>
                        <li><a class="tumblr" href="#"><i class="fa fa-tumblr"></i></a></li>
                        <li><a class="instgram" href="#"><i class="fa fa-instagram"></i></a></li>
                        <li><a class="vimeo" href="#"><i class="fa fa-vimeo-square"></i></a></li>
                        <li><a class="skype" href="#"><i class="fa fa-skype"></i></a></li>
                     </ul>
                  </div>
               </div>
               <div class="col-md-3 col-xs-12">
                  <div class="footer-widget contact-widget wow zoomIn animated" data-wow-offset="10" data-wow-delay="0.5s">
                     <ul>
                        <li><span>Phone Number:</span> +1 225 650 9393</li>
                        <li><span>Email:</span> theschoolbook2016@gmail.com</li>
                        <li><span>Website:</span> www.schoolbook.com</li>
                     </ul>
                  </div>
               </div>
            </div>
            <div class="copyright-section wow zoomIn animated" data-wow-offset="10" data-wow-delay="0.5s">
               <div class="row">
                  <div class="col-md-6 col-sm-12 col-xs-12">
                     <p> &copy; 2016 SchoolBook - All Rights Reserved <a href="#">SchoolBook</a></p>
                  </div>
                  <div class="col-md-6 col-sm-12 col-xs-12">
                     <ul class="footer-nav">
                        <li><a href="#">Sitemap</a></li>
                        <li><a href="#">Privacy Policy</a></li>
                        <li><a href="#">Contact</a></li>
                     </ul>
                  </div>
               </div>
            </div>
         </div>
      </footer>
      <div class="scroll-top" data-spy="affix" data-offset-top="300"><a href="#header"><i class="fa fa-angle-up"></i></a></div>
      <script src="js/jquery.js" type="text/javascript"></script><script src="assets/js/bootstrap.min.js" type="text/javascript"></script><script src="js/jquery.backstretch.js" type="text/javascript"></script><script src="js/nav.js" type="text/javascript"></script><script src="js/vegas.min.js" type="text/javascript"></script><script src="js/owl.carousel.min.js" type="text/javascript"></script><script src="js/waypoints.min.js" type="text/javascript"></script><script src="js/counter.min.js" type="text/javascript"></script><script src="js/scroll-top.js" type="text/javascript"></script><script src="js/wow.min.js" type="text/javascript"></script><script src="js/main.js" type="text/javascript"></script>
    </form>
</body>
</html>

