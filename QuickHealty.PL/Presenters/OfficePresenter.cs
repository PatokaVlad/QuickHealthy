using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;

namespace QuickHealthy.PL.Presenters
{
    public class OfficePresenter : IPresenter<OfficeViewModel>
    {
        private IOfficeService _officeService;
        private IOfficeView _officeView;

        public OfficePresenter(IOfficeView officeView, IOfficeService officeService) {
            _officeService = officeService;
            _officeView = officeView;
        }

        public string Create(OfficeViewModel viewModel) {
            OfficeDTO officeDTO = new OfficeDTO
            {
                Description = viewModel.Description,
                DoctorId = viewModel.DoctorId
            };

            try
            {
                _officeService.Create(officeDTO);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            _officeView.ClearOfficeControls();

            return true.ToString();
        }

        public void LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<OfficeDTO, OfficeViewModel>()).CreateMapper();
            var offices = mapper.Map<IEnumerable<OfficeDTO>, List<OfficeViewModel>>(_officeService.GetAll());

            _officeView.LoadOffices(offices);
        }
    }
}
