using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveType, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveType, EmployeeVM>().ReverseMap();
        }
    }
}
