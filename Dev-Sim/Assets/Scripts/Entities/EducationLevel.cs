using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class EducationLevel
{
    #region Fields
    private enGraduation m_Graduation;
    private enSubjectOfStudy m_Subject;
    private float m_Grade;

    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public enGraduation Graduation
    {
        get { return m_Graduation; }
        set { m_Graduation = value; }
    }

    public enSubjectOfStudy Subject
    {
        get { return m_Subject; }
        set { m_Subject = value; }
    }

    public float Grade
    {
        get { return m_Grade; }
        set { m_Grade = value; }
    }

    #endregion

    #region Constructors
    #endregion

    #region Methods

    #region ClassMethods
    #endregion
    #endregion
}
