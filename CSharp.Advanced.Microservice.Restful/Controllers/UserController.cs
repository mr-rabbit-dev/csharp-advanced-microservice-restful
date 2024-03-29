﻿using System;
using Microsoft.AspNetCore.Mvc;

using CSharp.Advanced.Microservice.Restful.Models;

namespace CSharp.Advanced.Microservice.Restful.Controllers;

/**
 *  UserController.cs
 * 
 *  Author   Cristian Hume Henriquez
 *  Version  1.0.0
 *  Created  2022-11-28
 *  Modified 2022-11-28
 */
[ApiController]
[Route("api/csharp/v1/users")]
public class UserController : ControllerBase
{
    #region [PRIVATE-FIELDS]
    private List<UserModel> _userModelList;
    #endregion [PRIVATE-FIELDS]

    #region [PUBLIC-CONSTRUCTORS]
    public UserController()
    {
        _userModelList = FindHardCodedData();
    }
    #endregion [PUBLIC-CONSTRUCTORS]

    #region [PUBLIC-METHODS]
    [HttpPost]
    public IActionResult Create(UserModel userModel)
    {
        return StatusCode(StatusCodes.Status501NotImplemented);
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        List<UserModel> userModelList = _userModelList;

        return (userModelList != null ? (userModelList.Count > 0 ? Ok(userModelList) : NotFound()) : NotFound());
    }

    [HttpGet("{id}")]
    public IActionResult FindById(Int128 id)
    {
        UserModel? userModel = _userModelList.Find(item => item.Id == id); ;

        return (userModel != null ? Ok(userModel) : NotFound());
    }

    [HttpPut("{id}")]
    public IActionResult Update(Int32 id, UserModel userModel)
    {
        return StatusCode(StatusCodes.Status501NotImplemented);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Int32 id)
    {
        return StatusCode(StatusCodes.Status501NotImplemented);
    }
    #endregion [PUBLIC-METHODS]

    #region [PRIVATE-METHODS]
    private List<UserModel> FindHardCodedData()
    {
        List<UserModel> userModelList = new List<UserModel>()
        {
            new UserModel()
            {
                Id = 1,
                FirstName = "Bjarne",
                LastName = "Stroustrup",
                Nationality = "Danish",
                Occupation = "Computer Scientist",
                KnownFor = new List<string>()
                {
                    "C++ (Programming Language)"
                },
                Awards = new List<string>()
                {
                    "1993: The ACM Grace Murray Hopper award for his early work laying the foundations for the C++ programming language. Based on those foundations and Dr. Stroustrup's continuing efforts, C++ has become one of the most influential programming languages in the history of computing",
                    "2005: The William Procter Prize for Scientific Achievement from Sigma Xi (the scientific research society) as the first computer scientist ever",
                    "2010: The University of Aarhus's Rigmor og Carl Holst-Knudsens Videnskabspris",
                    "2017: The Faraday Medal from the IET (Institute of Engineering Technology) for significant contributions to the history of computing, in particular pioneering the C++ programming language",
                    "2018: The Charles Stark Draper Prize from The US National Academy of Engineering for conceptualizing and developing the C++ programming language",
                    "2018: The Computer Pioneer Award from The IEEE Computer Society for bringing object-oriented programming and generic programming to the mainstream with his design and implementation of the C++ programming language"
                },
                Email = "bjarne.stroustrup@email.com",
                Phone = "1-493-170-9623"
            },
            new UserModel()
            {
                Id = 2,
                FirstName = "James",
                LastName = "Gosling",
                Nationality = "Canadian",
                Occupation = "Computer Scientist",
                KnownFor = new List<string>()
                {
                    "Java (Programming Language)"
                },
                Awards = new List<string>()
                {
                    "2002: Awarded The Economist Innovation Award",
                    "2002: Awarded The Flame Award USENIX Lifetime Achievement Award",
                    "2007: Made an Officer of the Order of Canada. The Order is Canada's second highest civilian honor. Officers are the second highest grade within the Order",
                    "2013: Became a fellow of the Association for Computing Machinery",
                    "2015: Awarded IEEE John von Neumann Medal",
                    "2019: Named a Computer History Museum Fellow for the conception, design, and implementation of the Java programming language"

                },
                Email = "james.gosling@email.com",
                Phone = "2-663-123-4447"
            },
            new UserModel()
            {
                Id = 3,
                FirstName = "Guido",
                LastName = "Van Rossum",
                Nationality = "Netherlands",
                Occupation = "Benevolent Dictator for Life",
                KnownFor = new List<string>()
                {
                    "Python (Programming Language)"
                },
                Awards = new List<string>()
                {
                    "2002: FOSDEM conference in Brussels, Van Rossum received the 2001 Award for the Advancement of Free Software from the Free Software Foundation (FSF) for his work on Python",
                    "2003: He received a NLUUG Award",
                    "2006: He was recognized as a Distinguished Engineer by the Association for Computing Machinery",
                    "2018: He was made a Fellow of the Computer History museum",
                    "2019: He was awarded the honorary title of Dijkstra Fellow by CWI"
                },
                Email = "guido.van.rossum@email.com",
                Phone = "3-770-736-8031"
            },
            new UserModel()
            {
                Id = 4,
                FirstName = "Anders",
                LastName = "Hejlsberg",
                Nationality = "Danish",
                Occupation = "Lead Systems Architect",
                KnownFor = new List<string>()
                {
                    "CSharp (Programming Language)"
                },
                Awards = new List<string>()
                {
                    "2001: Received the Dr. Dobb's Excellence in Programming Award for his work on Turbo Pascal, Delphi, C# and the Microsoft .NET Framework",
                    "2007: Was awarded a Technical Recognition Award for Outstanding Technical Achievement for their work on the C# language"
                },
                Email = "anders.hejlsberg@email.com",
                Phone = "4-024-976-6794"
            },
            new UserModel()
            {
                Id = 5,
                FirstName = "Yukihiro",
                LastName = "Matsumoto ",
                Nationality = "Japanese",
                Occupation = "Computer Scientist,",
                KnownFor = new List<string>()
                {
                    "Ruby (Programming Language)"
                },
                Awards = new List<string>()
                {
                    "2011: Received award for the Advancement of Free Software from the Free Software Foundation (FSF) at the 2012 LibrePlanet conference at the University of Massachusetts Boston in Boston"
                },
                Email = "yukihiro.matsumoto@email.com",
                Phone = "5-024-976-6794"
            }
        };
        return userModelList;
    }
    #endregion [PRIVATE-METHODS]
}



