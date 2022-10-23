using AutoMapper;
using Bayi.Core.DTOs;
using Bayi.Core.Models;
using Bayi.Core.Repositories;
using Bayi.Core.Services;
using Bayi.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Service.Services
{
    public class AnaBayiService : Service<AnaBayi>, IAnaBayiService
    {
        private readonly IAnaBayiRepository _anaBayiRepository;
        private readonly IMapper _mapper;
        public AnaBayiService(IGenericRepository<AnaBayi> repository, IUnitOfWork unitOfWork, IMapper mapper, IAnaBayiRepository
            anaBayiRepository): base(repository, unitOfWork)
        {
            _mapper = mapper;
            _anaBayiRepository = anaBayiRepository;
        }

        public async Task<CustomResponseDTO<List<AnaBayiWithAltBayiDTO>>> GetAllAnaBayiWithAltBayi()
        {
            var anaBayiler = await _anaBayiRepository.GetAllAnaBayiWithAltBayi();
            var anaBayiDTO = _mapper.Map<List<AnaBayiWithAltBayiDTO>>(anaBayiler);
            return CustomResponseDTO<List<AnaBayiWithAltBayiDTO>>.Success(200,anaBayiDTO);
        }
    }
}
