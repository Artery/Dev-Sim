using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Worker// : MonoBehaviour
{
    #region Fields

    private string m_Name;
    private enSex m_Sex;
    private EducationLevel m_EducationLevel;
    private Dictionary<enField, List<Skill>> m_Skills;
    private List<WorkerAttribute> m_Attributes;
    private List<WorkerStatusValue> m_StatusValues;
    private List<WorkerAttributeTrait> m_AttributeTraits;
    private List<WorkerStatusValueTrait> m_StatusValueTraits;
    //ProductProperties?

    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }

    public enSex Sex
    {
        get { return m_Sex; }
        set { m_Sex = value; }
    }

    //public enEthnos Ethnos { get;  set; }
    public EducationLevel EducationLevel
    {
        get { return m_EducationLevel; }
        set { m_EducationLevel = value; }
    }

    public Dictionary<enField, List<Skill>> Skills
    {
        get { return m_Skills; }
        set { m_Skills = value; }
    }

    public List<WorkerAttribute> Attributes
    {
        get { return m_Attributes; }
        set { m_Attributes = value; }
    }

    public List<WorkerStatusValue> StatusValues
    {
        get { return m_StatusValues; }
        set { m_StatusValues = value; }
    }

    public List<WorkerAttributeTrait> AttributeTraits
    {
        get { return m_AttributeTraits; }
        set { m_AttributeTraits = value; }
    }

    public List<WorkerStatusValueTrait> StatusValueTraits
    {
        get { return m_StatusValueTraits; }
        set { m_StatusValueTraits = value; }
    }

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
    #endregion
    #endregion
}
