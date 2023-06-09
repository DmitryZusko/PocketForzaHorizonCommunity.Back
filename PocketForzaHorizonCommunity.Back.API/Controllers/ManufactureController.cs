﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities;
using PocketForzaHorizonCommunity.Back.DTO.DTOs.CarDtos;
using PocketForzaHorizonCommunity.Back.DTO.Requests;
using PocketForzaHorizonCommunity.Back.DTO.Requests.Car;
using PocketForzaHorizonCommunity.Back.DTO.Responses;
using PocketForzaHorizonCommunity.Back.Services.Exceptions;
using PocketForzaHorizonCommunity.Back.Services.Services.Interfaces;

namespace PocketForzaHorizonCommunity.Back.API.Controllers;

[Authorize]
public class ManufactureController : ApplicationControllerBase
{
    private readonly IManufactureService _service;
    public ManufactureController(IMapper mapper, IManufactureService manufactureService) : base(mapper)
    {
        _service = manufactureService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<PaginatedResponse<ManufactureDto>> GetAll([FromQuery] PaginationGetRequestBase request) =>
        _mapper.Map<PaginatedResponse<ManufactureDto>>(await _service.GetAllAsync(request));

    [HttpPost]
    [Authorize(Roles = "Administrator")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ManufactureDto> CreateManufacture([FromBody] CreateManufactureRequest request)
    {
        var newEntity = await _service.CreateAsync(_mapper.Map<Manufacture>(request));

        Response.StatusCode = StatusCodes.Status201Created;
        return _mapper.Map<ManufactureDto>(newEntity);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Administrator")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ManufactureDto> UpdateManufacture(UpdateManufactureRequest request)
    {
        var updatedEntity = await _service.UpdateAsync(_mapper.Map<Manufacture>(request));

        return _mapper.Map<ManufactureDto>(updatedEntity);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Administrator")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task Delete(string id)
    {
        if (!Guid.TryParse(id, out Guid manufacturerId)) throw new BadRequestException();

        await _service.DeleteAsync(manufacturerId);
    }
}
