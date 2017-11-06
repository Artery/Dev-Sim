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

    private enSkillType m_Type;
    private string m_Name;
    private float m_YearsOfExperience;
    private float m_Level;

    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public enSkillType Type
    {
        get { return m_Type; }
        set { m_Type = value; }
    }

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }

    public float YearsOfExperience
    {
        get { return m_YearsOfExperience; }
        set { m_YearsOfExperience = value; }
    }

    public float Level
    {
        get { return m_Level; }
        set { m_Level = value; }
    }

    #endregion

    #region Constructors
    #endregion

    #region Methods

    #region ClassMethods
    #endregion
    #endregion
}
