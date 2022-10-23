using AutoMapper;
using Bayi.Core.DTOs;
using Bayi.Core.Models;
using Bayi.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bayi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltBayiController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<AltBayi> _service;

        public AltBayiController(IMapper mapper, IService<AltBayi> service)
        {
            this._mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var altBayi = await _service.GetAllAsync();
            var altBayiDTO = _mapper.Map<List<AltBayiDTO>>(altBayi.ToList());
            return CreateActionResult(CustomResponseDTO<List<AltBayiDTO>>.Success(200, altBayiDTO));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var altBayi = await _service.GetByIdAsync(id);
            var altBayiDTO = _mapper.Map<AltBayiDTO>(altBayi);
            return CreateActionResult(CustomResponseDTO<AltBayiDTO>.Success(200, altBayiDTO));
        }
        [HttpPost]
        public async Task<IActionResult> Save(AltBayiDTO altBayiDTO)
        {
            var altBayi = await _service.AddAsync(_mapper.Map<AltBayi>(altBayiDTO));
            var altBayiPoint = _mapper.Map<AltBayiDTO>(altBayi);
            return CreateActionResult(CustomResponseDTO<AltBayiDTO>.Success(201, altBayiPoint));
        }
        [HttpPut]
        public async Task<IActionResult> Update(AltBayiDTO altBayiDTO)
        {
            await _service.UpdateAsync(_mapper.Map<AltBayi>(altBayiDTO));
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var altBayi = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(altBayi);
            return CreateActionResult(CustomResponseDTO<AltBayiDTO>.Success(204));
        }

    }
}
