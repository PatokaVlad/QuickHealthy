using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.PL.Presenters
{
    public class DoctorPresenter : IPresenter<DoctorViewModel>
    {
        private IDoctorService _doctorService;
        private IDoctorView _doctorView;

        public DoctorPresenter(IDoctorView doctorView, IDoctorService doctorService) {
            _doctorService = doctorService;
            _doctorView = doctorView;
        }

        public string Create(DoctorViewModel viewModel) {
            DoctorDTO doctorDTO = new DoctorDTO
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                JobPosition = viewModel.JobPosition,
                StartWorkTime = viewModel.StartWorkTime,
                EndWorkTime = viewModel.EndWorkTime,
                OfficeId = viewModel.OfficeId
            };

            try
            {
                _doctorService.Create(doctorDTO);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _doctorView.ClearDoctorControls();

            return true.ToString();
        }

        public void LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<DoctorDTO, DoctorViewModel>()).CreateMapper();
            var doctors = mapper.Map<IEnumerable<DoctorDTO>, List<DoctorViewModel>>(_doctorService.GetAll());

            _doctorView.LoadDoctors(doctors);
        }

        public DoctorViewModel Get(int? doctorId) {
            DoctorDTO doctorDTO = _doctorService.Get(doctorId);

            return new DoctorViewModel
            {
                Id = doctorDTO.Id,
                FirstName = doctorDTO.FirstName,
                LastName = doctorDTO.LastName,
                JobPosition = doctorDTO.JobPosition,
                StartWorkTime = doctorDTO.StartWorkTime,
                EndWorkTime = doctorDTO.EndWorkTime,
                OfficeId = doctorDTO.OfficeId
            };
        }
    }
}
