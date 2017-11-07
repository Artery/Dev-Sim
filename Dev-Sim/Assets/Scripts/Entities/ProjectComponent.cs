using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;

/// <summary>
/// Class summary goes here...
/// </summary>
public class ProjectComponent
{
    #region Fields

    private enComponentType m_ComponentType;
    private string m_Name;
    #endregion

    #region Properties

    public enComponentType ComponentType
    {
        get { return m_ComponentType; }
        set { m_ComponentType = value; }
    }

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #region ClassMethods

    #endregion

    #endregion
}