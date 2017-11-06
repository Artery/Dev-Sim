using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Customer : MonoBehaviour
{
    #region Fields

    private string m_Name;
    //Type? Firma, Person
    private double m_Satisfaction;
    private List<CustomerTrait> m_Traits;
    private double m_Loyalty;

    #region SerializedFields

    #endregion

    #endregion

    #region Properties

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }
    public double Satisfaction
    {
        get { return m_Satisfaction; }
        set { m_Satisfaction = value; }
    }
    public List<CustomerTrait> Traits
    {
        get { return m_Traits; }
        set { m_Traits = value; }
    }
    public double Loyalty
    {
        get { return m_Loyalty; }
        set { m_Loyalty = value; }
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