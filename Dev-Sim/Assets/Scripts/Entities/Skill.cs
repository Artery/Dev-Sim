using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Skill
{
    #region Fields
    #region SerializedFields
    #endregion
    #endregion

    #region Properties
    public enSkillType Type { get; protected set; }
    public string Name { get; protected set; }
    public float YearsOfExperience { get; set; }
    public float Level { get; set; }
    #endregion

    #region Constructors
    #endregion

    #region Methods

    #region ClassMethods
    #endregion
    #endregion
}
