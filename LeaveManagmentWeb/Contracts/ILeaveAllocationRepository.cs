﻿using LeaveManagmentWeb.Data;
using LeaveManagmentWeb.Models;

namespace LeaveManagmentWeb.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId,int leaveTypeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM model);
    }
}