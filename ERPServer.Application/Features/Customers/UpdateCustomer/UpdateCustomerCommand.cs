using AutoMapper;
using ERPServer.Application.Features.Customers.CreateCustomer;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERPServer.Application.Features.Customers.UpdateCustomer
{
    public sealed record class UpdateCustomerCommand(
        Guid Id,
        string Name,
        string TaxDepartment,
        string TaxNumber,
        string City,
        string Town,
        string FullAddress) : IRequest<Result<string>>;
}
