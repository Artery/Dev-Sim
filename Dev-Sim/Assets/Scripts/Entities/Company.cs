﻿using System;
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
    private string m_Name;
    private float m_Reputation;
    private float m_WorkingAtmosphere;
    private List<CompanyTrait> m_Traits;
    private float m_CreditWorthiness;
    private Dictionary<enField, List<Tool>> m_Tools;
    private Finances m_Finances;
    private List<Worker> m_Employees;
    private List<Project> m_Projects;
    private List<Product> m_Products;

    #region SerializedFields
    #endregion
    #endregion

    #region Properties

    public string Name
    {
        get { return m_Name; }
        protected set { m_Name = value; }
    }
    public float Reputation
    {
        get { return m_Reputation; }
        protected set { m_Reputation = value; }
    }
    public float WorkingAtmosphere
    {
        get { return m_WorkingAtmosphere; }
        protected set { m_WorkingAtmosphere = value; }
    }
    public List<CompanyTrait> Traits
    {
        get { return m_Traits; }
        protected set { m_Traits = value; }
    }
    public float CreditWorthiness
    {
        get { return m_CreditWorthiness; }
        protected set { m_CreditWorthiness = value; }
    }
    public Dictionary<enField, List<Tool>> Tools
    {
        get { return m_Tools; }
        protected set { m_Tools = value; }
    }
    public Finances Finances
    {
        get { return m_Finances; }
        protected set { m_Finances = value; }
    }
    public List<Worker> Employees
    {
        get { return m_Employees; }
        protected set { m_Employees = value; }
    }
    public List<Project> Projects
    {
        get { return m_Projects; }
        protected set { m_Projects = value; }
    }
    public List<Product> Products
    {
        get { return m_Products; }
        protected set { m_Products = value; }
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
