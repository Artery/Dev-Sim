using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Worker : MonoBehaviour
{
    #region Fields
    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public string Name { get; protected set; }
    public enSex Sex { get; protected set; }
    //public enEthnos Ethnos { get; protected set; }
    public EducationLevel EducationLevel { get; protected set; }
    public Dictionary<enField, List<Skill>> Skills { get; protected set; }
    public List<WorkerAttribute> Attributes { get; protected set; }
    public List<WorkerStatusValue> StatusValues { get; protected set; }
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
