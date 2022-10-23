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
    public class AnaBayiController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<AnaBayi> _service;
        private readonly IAnaBayiService anaBayiService;

        public AnaBayiController(IMapper mapper, IService<AnaBayi> service, IAnaBayiService anaBayiService)
        {
            _mapper = mapper;
            _service = service;
            this.anaBayiService = anaBayiService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAnaBayiWithAltBayi()
        {
            return CreateActionResult(await anaBayiService.GetAllAnaBayiWithAltBayi());
        }

        [HttpGet]
        public async Task<IActionResult>All()
        {
            var anaBayi = await _service.GetAllAsync();
            var anaBayiDTO = _mapper.Map<List<AnaBayiDTO>>(anaBayi.ToList());
            return CreateActionResult(CustomResponseDTO<List<AnaBayiDTO>>.Success(200, anaBayiDTO));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var anaBayi = await _service.GetByIdAsync(id);
            var anaBayiDTO = _mapper.Map<AnaBayiDTO>(anaBayi);
            return CreateActionResult(CustomResponseDTO<AnaBayiDTO>.Success(200, anaBayiDTO));
        }
       // [Authorize]
        [HttpPost]
        public async Task<IActionResult> Save(AnaBayiDTO anaBayiDTO)
        {
            var anaBayi = await _service.AddAsync(_mapper.Map<AnaBayi>(anaBayiDTO));
            var anaBayiPoint = _mapper.Map<AnaBayiDTO>(anaBayi);
            return CreateActionResult(CustomResponseDTO<AnaBayiDTO>.Success(201, anaBayiPoint));
        }
        [HttpPut]
        public async Task<IActionResult> Update(AnaBayiDTO anaBayiDTO)
        {
            await _service.UpdateAsync(_mapper.Map<AnaBayi>(anaBayiDTO));
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var anaBayi = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(anaBayi);
            return CreateActionResult(CustomResponseDTO<AnaBayiDTO>.Success(204));
        }

    }
}
