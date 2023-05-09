import { IAchivement } from "@/data-transfer-objects/entities/Achivement";
import { IDesign } from "@/data-transfer-objects/entities/Design";
import { ITune } from "@/data-transfer-objects/entities/Tune";
import { INewsItem } from "@/data-transfer-objects/entities/NewsItem";
import { ActionCreatorWithPayload } from "@reduxjs/toolkit";
import { ICar } from "@/data-transfer-objects/entities/Car";
import { OrderDirection } from "@/components/CarTableComponent/components/SortingTableHead/SortingTableHead";
import { IManufacture } from "@/data-transfer-objects/entities/Manufacture";
import { ICarType } from "@/data-transfer-objects/entities/CarType";
import { ISimplifiedCar } from "@/data-transfer-objects/entities/SimplifiedCar";

export type ActionWithPayload<Payload> = ReturnType<ActionCreatorWithPayload<Payload>>;

export interface INewsState {
  isLoading: boolean;
  news: INewsItem[];
  count: number;
}

export interface ISortingPayload<TEntity> {
  order: OrderDirection;
  orderBy: keyof TEntity;
}

export interface IGameStatisticsState {
  isLoadingPlayersNumber: boolean;
  totalPlayers: number;
  isLoadingAchievements: boolean;
  achievements: IAchivement[];
}

export interface IDesignState {
  isLoadingLatest: boolean;
  latestDesigns: IDesign[];
  isLoadingDesigns: boolean;
  designs: IDesign[];
  page: number;
  pageSize: number;
  totalEntities: number;
}

export interface ITuneState {
  isLoadingLatest: boolean;
  latestTunes: ITune[];
}

export interface ICarState {
  isLoadingCars: boolean;
  cars: ICar[];
  page: number;
  pageSize: number;
  totalEntities: number;
}

export interface IFiltetSchemeState {
  isLoadingCarTypes: boolean;
  carTypes: ICarType[];
  totalCarTypes: number;
  isLoadingManufacture: boolean;
  manufactures: IManufacture[];
  totalManufactures: number;
  isLoadingCarNames: boolean;
  carNames: ISimplifiedCar[];
  isLoadingCarFilterScheme: boolean;
  minPrice: number;
  maxPrice: number;
  minYear: number;
  maxYear: number;
}

export interface ISelectedFilterParamsState {
  selectedPriceRange: number[];
  selectedYearRange: number[];
  selectedManufactures: string[];
  selectedCarTypes: string[];
  selectedCountries: string[];
}
