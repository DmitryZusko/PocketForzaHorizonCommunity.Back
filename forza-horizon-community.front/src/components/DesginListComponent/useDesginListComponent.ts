import {
  carNamesSelector,
  cleanUpDesigns,
  designsSelector,
  getCarNames,
  getDesigns,
  getDesignsByCarId,
  setDesignPage,
  turnDesignPage,
  useAppDispatch,
  useAppSelector,
} from "@/redux";
import { useState, useCallback, useMemo, useEffect } from "react";
import { defaultCardDescriptionLimit } from "../constants";

export const useDesginListComponent = () => {
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCar, setSelectedCar] = useState<string | undefined>("");

  const { carNames } = useAppSelector(carNamesSelector);

  const { isLoadingDesigns, designs, page, pageSize, totalEntities } =
    useAppSelector(designsSelector);

  const dispatch = useAppDispatch();

  const loadCars = useCallback(() => {
    dispatch(getCarNames());
  }, [dispatch]);

  const loadDesigns = useCallback(() => {
    if (selectedCar) {
      return dispatch(
        getDesignsByCarId({
          page,
          pageSize,
          searchQuery: searchQuery,
          descriptionLimit: defaultCardDescriptionLimit,
          carId: selectedCar,
        }),
      );
    }
    return dispatch(
      getDesigns({
        page,
        pageSize,
        searchQuery: searchQuery,
        descriptionLimit: defaultCardDescriptionLimit,
      }),
    );
  }, [searchQuery, page, pageSize, selectedCar, dispatch]);

  const autocompleteOptions = useMemo(() => {
    return carNames.map((item) => ({
      label: item.carName,
      id: item.id,
    }));
  }, [carNames]);

  //To clean up old results and start fetching for a new query paramsand, old design[] should be cleaned up and page set  to 0
  const handleSearchQueryChange = useCallback(
    (newQuery: string) => {
      setSearchQuery(newQuery);
      dispatch(cleanUpDesigns());
      dispatch(setDesignPage(0));
    },
    [setSearchQuery, dispatch],
  );

  //To clean up old results and start fetching for a new query paramsand, old design[] should be cleaned up and page set  to 0
  const handleAutocompleteChange = useCallback(
    (event: any, newValue: { label: string; id: string } | null) => {
      setSelectedCar(newValue?.id);
      dispatch(cleanUpDesigns());
      dispatch(setDesignPage(0));
    },
    [setSelectedCar, dispatch],
  );

  //to trigger further designs loading we simply change a page
  const loadNext = useCallback(() => {
    dispatch(turnDesignPage());
  }, [dispatch]);

  useEffect(() => {
    loadCars();
  }, [loadCars]);

  useEffect(() => {
    let isDispatched: boolean = false;
    var dispatchPromise = loadDesigns();
    dispatchPromise.then(() => (isDispatched = true));
    return () => {
      if (!isDispatched) {
        dispatchPromise.abort();
      }
    };
  }, [loadDesigns]);

  //If user leaves the page and that returns, designs[] will contain previouse results and a new session will load the same designs and push it and old array.
  //To prevent a such behavior, on a component unmounts designs[] should be cleaned up
  useEffect(() => {
    return () => {
      dispatch(cleanUpDesigns());
      dispatch(setDesignPage(0));
    };
  }, [dispatch]);

  return {
    searchQuery,
    autocompleteOptions,
    designs,
    page,
    pageSize,
    totalEntities,
    handleSearchQueryChange,
    handleAutocompleteChange,
    loadNext,
    loadDesigns,
  };
};
