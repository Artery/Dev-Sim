using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class summary goes here...
/// </summary>
public class ProjectCreationManager : MonoBehaviour
{
    #region Fields

    public enProjectCreationStage m_CurrentState = enProjectCreationStage.NONE;
    private Project m_NewProject;

    #region SerializedFields
    [SerializeField]
    private List<GameObject> m_Panels;

    [SerializeField]
    private List<GameObject> m_PlattformPanels;

    [SerializeField]
    private List<GameObject> m_ComponentsPanels;

    [SerializeField]
    private List<GameObject> m_FrameworksPanels;

    [SerializeField]
    private List<Slider> m_SpecificationSliders;


    [SerializeField]
    private Text m_ProjectName;
    #endregion

    #endregion

    #region Properties

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #region MonoMethods

    void Awake() { }

    void Start() { }

    void Update() { }

    #endregion

    #region ClassMethods
    public void SetProjectType(int intProjectType)
    {
        if(Enum.IsDefined(typeof(enProjectType), intProjectType))
        {
            var projectType = (enProjectType)intProjectType;
            m_NewProject.ProjectType = projectType;
            m_NewProject.WorkingTitle = m_ProjectName.text;
            ShowNextStage();
        }
    }

    public void SetPlattform(int intPlattform)
    {
        if (Enum.IsDefined(typeof(enPlattform), intPlattform))
        {
            var plattform = (enPlattform)intPlattform;
            m_NewProject.Plattform = plattform;
            ShowNextStage();
        }
    }

    public void ConfirmComponents()
    {
        List<Toggle> toggles = new List<Toggle>();
        toggles.AddRange(m_ComponentsPanels.
            ElementAt((int)m_NewProject.ProjectType).
            GetComponentsInChildren<Toggle>());
        for (int index = 0; index < toggles.Count; index++)
        {
            if (Enum.IsDefined(typeof(enComponentType), index)
                && toggles.ElementAt(index).isOn)
            {
                m_NewProject.ProjectComponents.
                    Add(new ProjectComponent() { ComponentType = (enComponentType)index });
            }
        }
        ShowNextStage();
    }

    public void ConfirmFrameworks()
    {
        List<Dropdown> frameworkDropdowns = new List<Dropdown>();
        frameworkDropdowns.AddRange(m_FrameworksPanels.
            ElementAt((int)m_NewProject.ProjectType).
            GetComponentsInChildren<Dropdown>());

        for (int index = 0; index < frameworkDropdowns.Count; index++)
        {
            int frameworkID = frameworkDropdowns.ElementAt(index).value;
            int componentID = index * 100;
            int typeID = (int)m_NewProject.ProjectType * 1000;
            int intFrameworkType = frameworkID + componentID + typeID;

            if (Enum.IsDefined(typeof(enFrameworkType), intFrameworkType))
            {
                m_NewProject.Frameworks.Add(new Framework() { FrameworkType = (enFrameworkType)intFrameworkType });
            }
        }

        ShowNextStage();
    }

    public void ConfirmSpecifications()
    {
        m_NewProject.Specification.FrontendEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.FRONTEND).value;
        m_NewProject.Specification.DatabaseEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.DATABASE).value;
        m_NewProject.Specification.BackendEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.BACKEND).value;
        m_NewProject.Specification.ModifiabilityEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.MODIFIABILITY).value;
        m_NewProject.Specification.PortabilityEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.PORTABILITY).value;
        m_NewProject.Specification.DocumentationEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.DOCUMENTATION).value;
        m_NewProject.Specification.PerformanceEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.PERFORMANCE).value;
        m_NewProject.Specification.CorrectnessEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.CORRECTNESS).value;
        m_NewProject.Specification.SecurityEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.SECURITY).value;
        m_NewProject.Specification.UsabilityEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.USABILITY).value;
        m_NewProject.Specification.RobustnessEffort = m_SpecificationSliders.
                                                        ElementAt((int)enSpecificationTypeID.ROBUSTNESS).value;

        ShowNextStage();
    }

    public void ConfirmTools()
    {
        ShowNextStage();
    }

    public void ConfirmDevelopmentMethod(int intDevelopmentFramework)
    {
        if (Enum.IsDefined(typeof(enDevelopmentMethodType), intDevelopmentFramework))
        {
            m_NewProject.DevelopmentMethod.Type = (enDevelopmentMethodType)intDevelopmentFramework;

            ShowNextStage();
        }
    }

    public void ConfirmRoles()
    {
        ShowNextStage();
    }

    public void ConfirmEstimationsSummary()
    {
        ShowNextStage();
    }

    public void ConfirmBudget()
    {
        ShowNextStage();
    }

    public void ConfirmProjectCreation()
    {
        m_Panels.ElementAt((int)m_CurrentState).SetActive(false);
        m_CurrentState = enProjectCreationStage.NONE;

        TestGame.Instance.AddNewProject(m_NewProject);
    }


    public void StartProjectCreation()
    {
        m_NewProject = new Project();
        m_Panels.ElementAt(0).SetActive(true);
        m_CurrentState = 0;
    }

    public void ShowNextStage()
    {
        HandleSubPanelVisibility(false);
        m_Panels.ElementAt((int)m_CurrentState).SetActive(false);
        m_Panels.ElementAt((int) ++m_CurrentState).SetActive(true);
        HandleSubPanelVisibility(true);
    }
    public void ShowPreviousStage()
    {
        HandleSubPanelVisibility(false);
        m_Panels.ElementAt((int)m_CurrentState).SetActive(false);
        m_Panels.ElementAt((int) --m_CurrentState).SetActive(true);
        HandleSubPanelVisibility(true);
    }

    public void ShowStageAt(int index)
    {
        if (Enum.IsDefined(typeof(enProjectType), index))
        {
            HandleSubPanelVisibility(false);
            m_Panels.ElementAt((int)m_CurrentState).SetActive(false);
            m_Panels.ElementAt(index).SetActive(true);
            HandleSubPanelVisibility(true);
        }
    }

    private void HandleSubPanelVisibility(bool activatePanel)
    {
        switch (m_CurrentState)
        {
            case enProjectCreationStage.PLATTFORM:
                m_PlattformPanels.ElementAt((int) m_NewProject.ProjectType).SetActive(activatePanel);
                break;
            case enProjectCreationStage.COMPONENTS:
                m_ComponentsPanels.ElementAt((int)m_NewProject.ProjectType).SetActive(activatePanel);
                break;
            case enProjectCreationStage.FRAMEWORKS:
                m_FrameworksPanels.ElementAt((int)m_NewProject.ProjectType).SetActive(activatePanel);
                break;
            default:
                break;
        }
    }
    #endregion

    #endregion
}