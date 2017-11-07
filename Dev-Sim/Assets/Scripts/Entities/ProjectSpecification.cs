using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Class summary goes here...
/// </summary>
public class ProjectSpecification
{
    #region Fields

    private float m_FrontendEffort;
    private float m_DatabaseEffort;
    private float m_BackendEffort;

    private float m_ModifiabilityEffort;
    private float m_PortabilityEffort;
    private float m_DocumentationEffort;
    private float m_PerformanceEffort;
    private float m_CorrectnessEffort;
    private float m_SecurityEffort;
    private float m_UsabilityEffort;
    private float m_RobustnessEffort;

    #endregion

    #region Properties

    public float FrontendEffort
    {
        get { return m_FrontendEffort; }
        set { m_FrontendEffort = value; }
    }

    public float DatabaseEffort
    {
        get { return m_DatabaseEffort; }
        set { m_DatabaseEffort = value; }
    }

    public float BackendEffort
    {
        get { return m_BackendEffort; }
        set { m_BackendEffort = value; }
    }

    public float ModifiabilityEffort
    {
        get { return m_ModifiabilityEffort; }
        set { m_ModifiabilityEffort = value; }
    }

    public float PortabilityEffort
    {
        get { return m_PortabilityEffort; }
        set { m_PortabilityEffort = value; }
    }

    public float DocumentationEffort
    {
        get { return m_DocumentationEffort; }
        set { m_DocumentationEffort = value; }
    }

    public float PerformanceEffort
    {
        get { return m_PerformanceEffort; }
        set { m_PerformanceEffort = value; }
    }

    public float CorrectnessEffort
    {
        get { return m_CorrectnessEffort; }
        set { m_CorrectnessEffort = value; }
    }

    public float SecurityEffort
    {
        get { return m_SecurityEffort; }
        set { m_SecurityEffort = value; }
    }

    public float UsabilityEffort
    {
        get { return m_UsabilityEffort; }
        set { m_UsabilityEffort = value; }
    }

    public float RobustnessEffort
    {
        get { return m_RobustnessEffort; }
        set { m_RobustnessEffort = value; }
    }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #region ClassMethods

    #endregion

    #endregion
}