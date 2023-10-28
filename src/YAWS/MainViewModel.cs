// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS;

using MvvmGen;
using MvvmGen.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using YAWS.About;
using YAWS.Core;
using YAWS.Core.Events;
using YAWS.Help;
using YAWS.LernLinqWithGavin;
using YAWS.Scan;

 // Linq ==>  https://github.com/GavinLonDigital/LINQExamples_2/blob/main/LINQExamples_2/Program.cs
// Base of MVVM ==> https://github.com/thomasclaudiushuber/mvvmgen
[ViewModel]
//[Inject(typeof(IEventAggregator))]
public partial class MainViewModel
{

    [Property]
    private ObservableCollection<IDashbordItem> items = new(new IDashbordItem[] { new ScanViewModel(), new AboutViewModel(), new HelpViewModel() });
    //public MainViewModel()
    //{
    //    this.SelectedItem ??= this.items.First();
    //}

    [Command(CanExecuteMethod = nameof(CanChangePage))]
    private void ChangePage(object? inputParameter)
    {
        if (inputParameter is not IDashbordItem dashbordItem)
        {
            return;
        }
        this.SelectedItem = dashbordItem;
    }
    private bool CanChangePage(object inputParameter)
    {
        return inputParameter is IDashbordItem;
    }


    [Property]
    private IDashbordItem selectedItem;

    public void Init()
    {
        var employeeList = Data.GetEmployees();
        var departmentList = Data.GetDepartments(employeeList);

        // SequenceEqual
        var employeeListCompare = Data.GetEmployees();
        bool boolSequenceEqual = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());

        // employeeList.ForEach(employee => DisplayEmployee(employee));

        //JOIN
        var resultJoin = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id, (emp, dept) => new
        {
            Id = emp.Id,
            FirstName = emp.FirstName,
            LastName = emp.LastName,
            AnnualSalary = emp.AnnualSalary,
            DepartmentId = emp.DepartmentId,
            DepartmentName = dept.LongName
        }).OrderBy(o => o.DepartmentId).ThenByDescending(o => o.AnnualSalary);

        // GroupJOIN
        var resultGroupJoin = employeeList.GroupJoin(departmentList, e => e.DepartmentId, d => d.Id, (emp, dept) => new
        {
            Id = emp.Id,
            FirstName = emp.FirstName,
            LastName = emp.LastName,
            AnnualSalary = emp.AnnualSalary,
            DepartmentId = emp.DepartmentId
            
        }).OrderBy(o => o.DepartmentId).ThenByDescending(o => o.AnnualSalary);

        Debug.WriteLine("");
        foreach (var item in resultJoin)
        {
            Debug.WriteLine($" Last Name: {item.LastName,-10} Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}");

        }
        Debug.WriteLine("");
        foreach (var item in resultJoin)
        {
            Debug.WriteLine($" Last Name: {item.LastName,-10} Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}");

        }
        //  resultJoin.ForEach(employee => );

        void DisplayEmployee(Employee employee)
        {
            Debug.WriteLine($"{employee.FirstName,-10}{employee.LastName,-10} IsManager: {employee.IsManager,-20}");
        }

    }

}


