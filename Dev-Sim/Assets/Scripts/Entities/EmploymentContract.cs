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
    public Worker Employee { get;  set; }
    public Company Employer { get;  set; }
    public WorkerRole Role { get;  set; }
    public ModeOfEmployment ModeOfEmployment { get;  set; }
    public int Salary { get;  set; }
    //In months, -1 is open-ended
    public int ContractDuration { get;  set; }
    #endregion

    #region Constructors
    #endregion

    #region Methods
    #region ClassMethods
    #endregion
    #endregion
}
