using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Company : MonoBehaviour
{
    #region Fields
    #region SerializedFields
    #endregion
    #endregion

    #region Properties
    public string Name { get; protected set; }
    public float Reputation { get; protected set; }
    public float WorkingAtmosphere { get; protected set; }
    public List<CompanyTrait> Traits { get; protected set; }
    public float CreditWorthiness { get; protected set; }
    public Dictionary<enField, List<Tool>> Tools { get; protected set; }
    public Finances Finances { get; protected set; }
    public List<Worker> Employees { get; protected set; }
    public List<Project> Projects { get; protected set; }
    public List<Product> Products { get; protected set; }

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
