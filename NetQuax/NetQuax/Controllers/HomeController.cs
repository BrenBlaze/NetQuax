﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetQuax.Entities;

namespace NetQuax.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      //NetQuax.Entities.User user = new NetQuax.Entities.User(1);
     
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }


    /// <summary cref="User" >">
    /// Adds A new user based upon inputs from add user form
    /// </summary> 
    public ActionResult AddUser(FormCollection form)
    {
      string detectedUserName = string.Empty;
      string detectedPassword = string.Empty;
      string detectedPasswordConfirmation = string.Empty;
      string errorMessage = string.Empty;
      bool errorFlag = false;
      if(form != null)
      {
        if (form.AllKeys.Contains("UserName"))
        {
          detectedUserName = form["UserName"];
        }
        if(form.AllKeys.Contains("Password"))
        {
          detectedPassword = form["Password"];
        }
        if(form.AllKeys.Contains("PasswordConfirmation"))
        {
          detectedPasswordConfirmation = form["PasswordConfirmation"];
        }
      }

      if(detectedUserName == string.Empty)
      {
        errorFlag = true;
        errorMessage = "Username is required";        
      }

      if(detectedPassword == string.Empty)
      {
        //TODO: Error
      }
      if (detectedPasswordConfirmation == string.Empty)
      {
        //TODO: Error
      }
      if (detectedPasswordConfirmation != detectedPassword)
      {
        //TODO: Error
      }
      if(!errorFlag)
      { 
        //Session["User"] = newUser;

        //TODO: return home view 
      }
      else
      {
        //TODO: Return Error View
      }
      return null;
    }
    // Method to be called when user checks out a movie
    public ActionResult CheckoutMovie(FormCollection form)
    {
        string errorMEssage = string.Empty;
        bool errorFlag = false;
        string detectedMovieId = string.Empty;
        string detectedUserId = string.Empty;
        if(form != null)
        {
            if(form.AllKeys.Contains("MovieId"))
            {
                detectedMovieId = form["MovieId"];
            }
            if(form.AllKeys.Contains("UserId"))
            {
                detectedUserId = form["UserId"];
            }
        }
        long movieId = long.MinValue;
        long.TryParse(detectedMovieId, out movieId);
        if(movieId <= 0)
        {
            errorFlag = true;
            errorMEssage = "Error: Movie does not exist!";
        }

        long userId = long.MinValue;
        long.TryParse(detectedUserId, out userId);
        if(userId <= 0)
        {
            //TODO: errorChecking
        }

        if(!errorFlag)
        {
            //TODO modify userdb to reflect changes
            //TODO return home view
        }
        else
        {
            //Don't update db
            //return error view
        }
        return null;
    }

    public ActionResult SignIn(FormCollection form)
    {
        string detectedUserName = string.Empty;
        string detectedPassword = string.Empty;
        string errorMessage = string.Empty;
        bool errorFlag = false;
        
        if(detectedUserName == string.Empty)
        {
            errorFlag = true;
            errorMessage = "Username is required";
        }
        if(detectedPassword == string.Empty)
        {
            errorMessage = "Password is required";
        }
        if (!errorFlag)
        {





            //TODO: Implement this thing
            //NetQuax.Entities.IUser user = NetQuax.Entities.User.RetrieveByUserName(detectedUserName);
        }
        return null;
    }

    public ActionResult SignOut()
    {
        Session["UserName"] = string.Empty;
        //TODO return home view
        return null;
    }

  }
}