using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Project
{

    #region Fields

    private string m_WorkingTitle;
    private ProjectCosts m_EstimatedProjectCosts = new ProjectCosts();
    private ProjectCosts m_FinalProjectCosts = new ProjectCosts();
    private ProjectDuration m_EstimatedDuration = new ProjectDuration();
    private ProjectDuration m_ActualDuration = new ProjectDuration();
    private List<Worker> m_AssignedWorkers = new List<Worker>();
    private enProjectType m_ProjectType;
    private enPlattform m_Plattform;
    private List<ProjectComponent> m_ProjectComponents = new List<ProjectComponent>();
    private List<Framework> m_Frameworks = new List<Framework>();
    private List<Tool> m_Tools = new List<Tool>();
    private DevelopmentMethod m_DevelopmentMethod = new DevelopmentMethod();
    private ProjectSpecification m_Specification = new ProjectSpecification();
    private ProjectEffort m_EstimatedEffort = new ProjectEffort();
    private ProjectEffort m_ResidualEffort = new ProjectEffort();
    //Quality?
    private double m_ErrorRate;
    private double m_CurrentCustomerStatisfaction;
    private Customer m_InvolvedCustomer;

    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public string WorkingTitle
    {
        get { return m_WorkingTitle; }
        set { m_WorkingTitle = value; }
    }
    public ProjectCosts EstimatedProjectCosts
    {
        get { return m_EstimatedProjectCosts; }
        set { m_EstimatedProjectCosts = value; }
    }
    public ProjectCosts FinalProjectCosts
    {
        get { return m_FinalProjectCosts; }
        set { m_FinalProjectCosts = value; }
    }
    public ProjectDuration EstimatedDuration
    {
        get { return m_EstimatedDuration; }
        set { m_EstimatedDuration = value; }
    }
    public ProjectDuration ActualDuration
    {
        get { return m_ActualDuration; }
        set { m_ActualDuration = value; }
    }
    public List<Worker> AssignedWorkers
    {
        get { return m_AssignedWorkers; }
        set { m_AssignedWorkers = value; }
    }
    public enProjectType ProjectType
    {
        get { return m_ProjectType; }
        set { m_ProjectType = value; }
    }
    public enPlattform Plattform
    {
        get { return m_Plattform; }
        set { m_Plattform = value; }
    }
    public List<ProjectComponent> ProjectComponents
    {
        get { return m_ProjectComponents; }
        set { m_ProjectComponents = value; }
    }
    public List<Framework> Frameworks
    {
        get { return m_Frameworks; }
        set { m_Frameworks = value; }
    }
    public List<Tool> Tools
    {
        get { return m_Tools; }
        set { m_Tools = value; }
    }
    public DevelopmentMethod DevelopmentMethod
    {
        get { return m_DevelopmentMethod; }
        set { m_DevelopmentMethod = value; }
    }
    public ProjectSpecification Specification
    {
        get { return m_Specification; }
        set { m_Specification = value; }
    }
    public ProjectEffort EstimatedEffort
    {
        get { return m_EstimatedEffort; }
        set { m_EstimatedEffort = value; }
    }
    public ProjectEffort ResidualEffort
    {
        get { return m_ResidualEffort; }
        set { m_ResidualEffort = value; }
    }
    public double ErrorRate
    {
        get { return m_ErrorRate; }
        set { m_ErrorRate = value; }
    }
    public double CurrentCustomerStatisfaction
    {
        get { return m_CurrentCustomerStatisfaction; }
        set { m_CurrentCustomerStatisfaction = value; }
    }
    public Customer InvolvedCustomer
    {
        get { return m_InvolvedCustomer; }
        set { m_InvolvedCustomer = value; }
    }

    #endregion

    #region Constructors
    #endregion

    #region Methods
    #region ClassMethods
    #endregion
    #endregion
}
