using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class TestGame : MonoBehaviour
{
    #region Fields

    public static TestGame Instance;

    #region SerializedFields
    [SerializeField]
    private Company m_Player;

    [SerializeField]
    private ProjectCreationManager m_ProjectCreationManager;
    #endregion

    #endregion

    #region Properties

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #region MonoMethods

    void Awake()
    {
        Instance = this;
        var playerWorker = new Worker()
                           {
                               Name = "Johannes Winkler",
                               Sex = enSex.MALE,
                               EducationLevel = new EducationLevel()
                                                {
                                                    Graduation = enGraduation.BACHELOR,
                                                    Subject = enSubjectOfStudy.ENGINEERING,
                                                    Grade = 2.7f
                                                },
                               Skills = new Dictionary<enField, List<Skill>>()
                                        {
                                            {
                                                enField.ENGINEERING, new List<Skill>()
                                                {
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.PROGRAMMING_LANGUAGE,
                                                        Name = "C#",
                                                        YearsOfExperience = 3f,
                                                        Level = 7f
                                                    },
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.FRAMEWORK,
                                                        Name = "WPF",
                                                        YearsOfExperience = 2f,
                                                        Level = 5f
                                                    },
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.PLATTFORM,
                                                        Name = "Windows",
                                                        YearsOfExperience = 3.5f,
                                                        Level = 6f
                                                    },
                                                }
                                            },
                                            {
                                                enField.COMMON, new List<Skill>()
                                                {
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.TESTING,
                                                        Name = "Testing general",
                                                        YearsOfExperience = 1.5f,
                                                        Level = 4f
                                                    },
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.USABILITY,
                                                        Name = "Usability general",
                                                        YearsOfExperience = 2f,
                                                        Level = 5f
                                                    },
                                                }
                                            }
                                        },
                               Attributes = new List<WorkerAttribute>()
                                            {
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.WORKING_SPEED,
                                                    Name = "WorkingSpeed",
                                                    Level = 1f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.NEAT_WORKING,
                                                    Name = "NeatWorking",
                                                    Level = 1.5f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.ABILITY_TO_COMMUNICATE,
                                                    Name = "AbilityToCommunicate",
                                                    Level = 2f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.STRESS_RESISTENCE,
                                                    Name = "StressResistence",
                                                    Level = 0.9f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.FRUSTRATION_TOLERANCE,
                                                    Name = "FrustrationTolerance",
                                                    Level = 0.9f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.WILLINGNESS_TO_LEARN,
                                                    Name = "WillingnessToLearn",
                                                    Level = 1.5f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.LEARNING_SPEED,
                                                    Name = "LearningSpeed",
                                                    Level = 1f,
                                                },
                                            },
                               StatusValues = new List<WorkerStatusValue>()
                                              {
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.BASE_PRODUCTIVITY,
                                                      Name = "Productivity",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.CURRENT_PRODUCTIVITY,
                                                      Name = "Productivity",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.HAPPINESS,
                                                      Name = "Happiness",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.STRESS,
                                                      Name = "Stress",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.ERROR_RATE,
                                                      Name = "ErrorRate",
                                                      Level = 1f
                                                  },
                                              },
                               AttributeTraits = new List<WorkerAttributeTrait>() { },
                               StatusValueTraits = new List<WorkerStatusValueTrait>() { }
                           };

        var coFounderWorker = new Worker()
                           {
                               Name = "Constantin Christandl",
                               Sex = enSex.MALE,
                               EducationLevel = new EducationLevel()
                                                {
                                                    Graduation = enGraduation.BACHELOR,
                                                    Subject = enSubjectOfStudy.ENGINEERING,
                                                    Grade = 2.3f
                                                },
                               Skills = new Dictionary<enField, List<Skill>>()
                                        {
                                            {
                                                enField.ENGINEERING, new List<Skill>()
                                                {
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.PROGRAMMING_LANGUAGE,
                                                        Name = "C#",
                                                        YearsOfExperience = 1f,
                                                        Level = 4f
                                                    },
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.PLATTFORM,
                                                        Name = "Windows",
                                                        YearsOfExperience = 3f,
                                                        Level = 5f
                                                    },
                                                }
                                            },
                                            {
                                                enField.COMMON, new List<Skill>()
                                                {
                                                    new Skill()
                                                    {
                                                        Type = enSkillType.TESTING,
                                                        Name = "Testing general",
                                                        YearsOfExperience = 0.5f,
                                                        Level = 1f
                                                    },
                                                }
                                            }
                                        },
                               Attributes = new List<WorkerAttribute>()
                                            {
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.WORKING_SPEED,
                                                    Name = "WorkingSpeed",
                                                    Level = 1.1f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.NEAT_WORKING,
                                                    Name = "NeatWorking",
                                                    Level = 1.5f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.ABILITY_TO_COMMUNICATE,
                                                    Name = "AbilityToCommunicate",
                                                    Level = 1.75f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.STRESS_RESISTENCE,
                                                    Name = "StressResistence",
                                                    Level = 1f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.FRUSTRATION_TOLERANCE,
                                                    Name = "FrustrationTolerance",
                                                    Level = 1f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.WILLINGNESS_TO_LEARN,
                                                    Name = "WillingnessToLearn",
                                                    Level = 1.5f,
                                                },
                                                new WorkerAttribute()
                                                {
                                                    Type = enWorkerAttributeType.LEARNING_SPEED,
                                                    Name = "LearningSpeed",
                                                    Level = 1.25f,
                                                },
                                            },
                               StatusValues = new List<WorkerStatusValue>()
                                              {
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.BASE_PRODUCTIVITY,
                                                      Name = "Productivity",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.CURRENT_PRODUCTIVITY,
                                                      Name = "Productivity",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.HAPPINESS,
                                                      Name = "Happiness",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.STRESS,
                                                      Name = "Stress",
                                                      Level = 1f
                                                  },
                                                  new WorkerStatusValue()
                                                  {
                                                      Type = enWorkerStatusValueType.ERROR_RATE,
                                                      Name = "ErrorRate",
                                                      Level = 1f
                                                  },
                                              },
                               AttributeTraits = new List<WorkerAttributeTrait>() { },
                               StatusValueTraits = new List<WorkerStatusValueTrait>() { }
                            };

        var firstProject = new Project()
                           {
                                WorkingTitle = "TestProject",
                                AssignedWorkers = new Dictionary<enWorkerRoleType, List<Worker>>()
                                                  {
                                                      {enWorkerRoleType.PROJECTMANAGER, new List<Worker>() {playerWorker}},
                                                      {enWorkerRoleType.DEVELOPER, new List<Worker>() {playerWorker, coFounderWorker}},
                                                  },
                                ProjectComponents = new List<ProjectComponent>() { },
                                Tools = new List<Tool>() { },
                                Specification = new ProjectSpecification() { }
                           };

        m_Player = new Company()
                   {
                       Name = "TestCompany",
                       Reputation = 0f,
                       WorkingAtmosphere = 0f,
                       Traits = new List<CompanyTrait>() { },
                       CreditWorthiness = 0f,
                       Tools = new Dictionary<enField, List<Tool>>() { },
                       Finances = new Finances() { },
                       Employees = new List<Worker> { playerWorker, coFounderWorker },
                       Projects = new List<Project>() { },
                       Products = new List<Product>() { }

                    };
    }

    void Start() { }

    void Update() { }

    #endregion

    #region ClassMethods

    public void CreateNewProject()
    {
        m_ProjectCreationManager.StartProjectCreation(m_Player);
    }

    public void AddNewProject(Project project)
    {
        m_Player.Projects.Add(project);
        Debug.Log(project.WorkingTitle);
    }
    #endregion

    #endregion
}