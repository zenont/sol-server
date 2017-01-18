using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.WebAPI.Mapping
{
    public class AutomapperConfig
    {
        public static void ConfigureMapper(IMapperConfigurationExpression cfg)
        {

            //// file activities
            //cfg.CreateMap<FileActivity, FileActivityDTO>().ReverseMap();
            //cfg.CreateMap<FileActivityDTO, FileActivity>().ReverseMap();

            //// misc
            //cfg.CreateMap<Market, MarketDTO>().ReverseMap();
            //cfg.CreateMap<Zone, ZoneDTO>().ReverseMap();
            //cfg.CreateMap<AllegroPoint, AllegroPointDTO>().ReverseMap();
            //cfg.CreateMap<FileRevision, FileRevisionDTO>().ReverseMap();
            //cfg.CreateMap<EmailRequest, EmailRequestDTO>();
            //cfg.CreateMap<EmailRequestDTO, EmailRequest>();
            //cfg.CreateMap<WacoeRequestUsageDTO, WacoeRequestUsage>();
            //cfg.CreateMap<WacoeRequestUsage, WacoeRequestUsageDTO>();
            //cfg.CreateMap<WacoeHistory, WacoeHistoryDTO>();
            //cfg.CreateMap<WacoeHistoryDTO, WacoeHistory>();
            //cfg.CreateMap<WacoeRequest, WacoeRequestDTO>();
            //cfg.CreateMap<WacoeRequestDTO, WacoeRequest>();
            //cfg.CreateMap<DbEnvironment, DbEnvironmentDTO>();
            //cfg.CreateMap<BasicDecimalReview, BasicDecimalReviewDTO>();
            //cfg.CreateMap<Wacoe, WacoeDTO>();
            //cfg.CreateMap<WacoeDTO, Wacoe>();
            //cfg.CreateMap<WacoeUser, WacoeUserDTO>();
            //cfg.CreateMap<AllReviews, AllReviewsDTO>();
            //cfg.CreateMap(typeof(DataSeries<,>), typeof(DataSeriesDTO<,>));
            //cfg.CreateMap(typeof(BasicReview<>), typeof(BasicReviewDTO<>));
            //cfg.CreateMap<EmailAttachment, EmailAttachmentDTO>();
            //cfg.CreateMap<EmailAttachmentDTO, EmailAttachment>();
            //cfg.CreateMap<LsPanComparoReview, LsPanComparoVolumeDTO>()
            //.ForMember(d => d.LodestarVolume, o => o.MapFrom(s => s.LsTotal))
            //.ForMember(d => d.PanoramaVolume, o => o.MapFrom(s => s.PanTotal));
            //cfg.CreateMap<LsPanComparoReview, LsPanComparoPriceDTO>()
            //.ForMember(d => d.LodestarPrice, o => o.MapFrom(s => s.LsTotal))
            //.ForMember(d => d.PanoramaPrice, o => o.MapFrom(s => s.PanTotal));
            //cfg.CreateMap<Addendum, AddendumDTO>();
            //cfg.CreateMap<AddendumTerm, AddendumTermDTO>();
            //cfg.CreateMap<ShadowSummary, ShadowSummaryDTO>();
            //cfg.CreateMap<ShadowSummaryEntry, ShadowSummaryEntryDTO>();
            //cfg.CreateMap<MeterTotal, MeterTotalDTO>()
            //    .ForMember(d => d.LdcNumber, o => o.MapFrom(s => s.LdcAccountNumber));

            //// wacoe search
            //cfg.CreateMap<WacoeItemFilters, WacoeItemFiltersDTO>();
            //cfg.CreateMap<FilterOption, FilterOptionDTO>();
            //cfg.CreateMap<PagingInfo, PagingInfoDTO>();
            //cfg.CreateMap<WacoeItemSearchResult, WacoeItemSearchResultDTO>()
            //.ForMember(d => d.Items, o => o.MapFrom(s => s.Wacoes))
            //.ForMember(d => d.Pagination, o => o.MapFrom(s => s.PagingInfo));
            //cfg.CreateMap<WacoeItemSearch, WacoeItemSearchDTO>();
            //cfg.CreateMap<WacoeItemSearchDTO, WacoeItemSearch>();

            //// wacoe history
            //cfg.CreateMap<WacoeHistoryDetails, WacoeHistoryDetailsDTO>();
            //cfg.CreateMap<WacoeHistory, WacoeHistoryDTO>();
            //cfg.CreateMap<WacoeHistoryDTO, WacoeHistory>();

            //// dashboard
            //cfg.CreateMap<Dashboard, DashboardDTO>();
            //cfg.CreateMap<ActiveTrade, ActiveTradeDTO>();
            //cfg.CreateMap<MonthlyLoadFollowing, MonthlyLoadFollowingDTO>();
            //cfg.CreateMap<FullRequirement, FullRequirementDTO>();
            //cfg.CreateMap<Invoice, InvoiceDTO>();
            //cfg.CreateMap<InvoiceCharge, InvoiceChargeDTO>();
            //cfg.CreateMap<PTChargeContract, PTChargeDTO>();
            //cfg.CreateMap<OtherCharge, OtherChargeDTO>();
            //cfg.CreateMap<TradePrice, TradePriceDTO>();
            //cfg.CreateMap<TradeVolume, TradeVolumeDTO>();
            //cfg.CreateMap<Block, BlockDTO>();
            //cfg.CreateMap<ProductPositionVolume, ProductPositionVolumeDTO>();
            //cfg.CreateMap<TradeVolumeWithDetails, TradeVolumeWithDetailsDTO>();
            //cfg.CreateMap<BlockPositionSum, BlockPositionSumDTO>();
            //cfg.CreateMap<ProductPosition, ProductPositionDTO>();
            //cfg.CreateMap<TradeVolumeRow, TradeVolumeRowDTO>();
            //cfg.CreateMap<DailyUsage, DailyUsageDTO>();
            //cfg.CreateMap<Graph, GraphDTO>();
            //cfg.CreateMap<LsPanComparo, LsPanComparoDTO>();
            //cfg.CreateMap<LsPanComparoReview, LsPanComparoPriceDTO>()
            //.ForMember(m => m.Name, o => o.MapFrom(s => s.TradeData))
            //.ForMember(m => m.LodestarPrice, o => o.MapFrom(s => s.LsTotal))
            //.ForMember(m => m.PanoramaPrice, o => o.MapFrom(s => s.PanTotal));
            //cfg.CreateMap<LsPanComparoReview, LsPanComparoVolumeDTO>()
            //.ForMember(m => m.Name, o => o.MapFrom(s => s.TradeData))
            //.ForMember(m => m.LodestarVolume, o => o.MapFrom(s => s.LsTotal))
            //.ForMember(m => m.PanoramaVolume, o => o.MapFrom(s => s.PanTotal));
            //cfg.CreateMap<PowerHrWithDetails, PowerHrWithDetailsDTO>();
            //cfg.CreateMap<PowerHrDetail, PowerHrDetailDTO>();

            //// one page
            //cfg.CreateMap<OnePage, OnePageDTO>();
            //cfg.CreateMap<DealTypeEntryReview, DealTypeEntryReviewDTO>();
            //cfg.CreateMap<PTChargeReview, PTChargeReviewDTO>();
            //cfg.CreateMap<FixedFeeReview, FixedFeeReviewDTO>();
            //cfg.CreateMap<ImbalanceCheck, ImbalanceCheckDTO>();
            //cfg.CreateMap<ImbalanceCheckDeal, ImbalanceCheckDealDTO>();
            //cfg.CreateMap<FixedBlock, FixedBlockDTO>();
            //cfg.CreateMap<DobReview, DobReviewDTO>();
            //cfg.CreateMap<PeriodVolume, PeriodVolumeDTO>();
            //cfg.CreateMap<PTChargeRate, PTChargeRateDTO>();
            //cfg.CreateMap<PTChargeRateRow, PTChargeRateRowDTO>();
            //cfg.CreateMap<PTChargeRateDetail, PTChargeRateDetailDTO>();

            //// evaluation
            //cfg.CreateMap<Evaluation, EvaluationDTO>();
            //cfg.CreateMap<EvaluationDTO, Evaluation>();
            //cfg.CreateMap<EvaluationResult, EvaluationResultDTO>();
            //cfg.CreateMap<InsertPriceEvaluation, InsertPriceEvaluationDTO>();
            //cfg.CreateMap<InsertPriceEvaluationDTO, InsertPriceEvaluation>();
        }

        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(ConfigureMapper);
            return config.CreateMapper();
        }
    }
}
