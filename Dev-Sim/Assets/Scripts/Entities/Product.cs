using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
public class Product
{
    #region Fields

    private string m_Name;
    //Bereich? z. B. App für Android
    private double m_DevelopmentCosts;
    private ProductCosts m_Costs;
    private ProductSales m_Sales;
    private List<Project> m_SubProjects;
    private ProductQuality m_Quality;
    //Version?
    //ProductCharacteristics?Properties?



    #region SerializedFields

    #endregion

    #endregion

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }
    public double DevelopmentCosts
    {
        get { return m_DevelopmentCosts; }
        set { m_DevelopmentCosts = value; }
    }
    public ProductCosts Costs
    {
        get { return m_Costs; }
        set { m_Costs = value; }
    }
    public ProductSales Sales
    {
        get { return m_Sales; }
        set { m_Sales = value; }
    }
    public List<Project> SubProjects
    {
        get { return m_SubProjects; }
        set { m_SubProjects = value; }
    }
    public ProductQuality Quality
    {
        get { return m_Quality; }
        set { m_Quality = value; }
    }

    #region Properties

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #region ClassMethods

    #endregion

    #endregion
}
