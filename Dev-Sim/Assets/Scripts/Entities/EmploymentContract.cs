using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Class summary goes here...
/// </summary>
class EmploymentContract
{
    #region Fields
    #region SerializedFields
    #endregion
    #endregion

    #region Properties
    public Worker Employee { get; protected set; }
    public Company Employer { get; protected set; }
    public WorkerRole Role { get; protected set; }
    public ModeOfEmployment ModeOfEmployment { get; protected set; }
    public int Salary { get; protected set; }
    //In months, -1 is open-ended
    public int ContractDuration { get; protected set; }
    #endregion

    #region Constructors
    #endregion

    #region Methods
    #region ClassMethods
    #endregion
    #endregion
}
