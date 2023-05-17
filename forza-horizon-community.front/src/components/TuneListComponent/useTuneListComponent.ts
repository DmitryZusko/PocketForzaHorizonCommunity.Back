import {
  carNamesSelector,
  cleanUpTunes,
  getCarNames,
  getTunes,
  getTunesByCarId,
  setTunePage,
  tunesSelector,
  turnTunePage,
  useAppDispatch,
  useAppSelector,
} from "@/redux";
import { useCallback, useEffect, useMemo, useState } from "react";

export const useTuneListComponent = () => {
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCar, setSelectedCar] = useState<string | undefined>("");

  const { carNames } = useAppSelector(carNamesSelector);

  const { tunes, page, pageSize, totalEntities } = useAppSelector(tunesSelector);

  const dispatch = useAppDispatch();

  const loadCars = useCallback(() => {
    dispatch(getCarNames());
  }, [dispatch]);

  const loadTunes = useCallback(() => {
    if (selectedCar) {
      return dispatch(
        getTunesByCarId({
          page,
          pageSize,
          searchQuery: searchQuery,
          carId: selectedCar,
        }),
      );
    }

    return dispatch(
      getTunes({
        page: 0,
        pageSize,
        searchQuery: searchQuery,
      }),
    );
  }, [selectedCar, searchQuery, page, pageSize, dispatch]);

  const autocompleteOptions = useMemo(() => {
    return carNames.map((item) => ({
      label: item.carName,
      id: item.id,
    }));
  }, [carNames]);

  //To clean up old results and start fetching for a new query paramsand, old tunes[] should be cleaned up and page set to 0
  const handleSearchQueryChange = useCallback(
    (newQuery: string) => {
      setSearchQuery(newQuery);
      dispatch(cleanUpTunes());
      dispatch(setTunePage(0));
    },
    [dispatch],
  );

  //To clean up old results and start fetching for a new query paramsand, old tunes[] should be cleaned up and page set to 0
  const handleAutocompleteChange = useCallback(
    (event: any, newValue: { label: string; id: string } | null) => {
      setSelectedCar(newValue?.id);
      dispatch(cleanUpTunes());
      dispatch(setTunePage(0));
    },
    [dispatch],
  );

  //to trigger further tunes loading we simply change a page
  const loadNext = useCallback(() => {
    dispatch(turnTunePage());
  }, [dispatch]);

  useEffect(() => {
    loadCars();
  }, [loadCars]);

  useEffect(() => {
    let isDispatched: boolean;
    var dispatchPromise = loadTunes();
    dispatchPromise.then(() => (isDispatched = true));
    return () => {
      if (!isDispatched) {
        dispatchPromise.abort();
      }
    };
  }, [loadTunes]);

  //If user leaves the page and that returns, tunes[] will contain previouse results and a new session will load the same tunes and push it to the old array.
  //To prevent a such behavior, on a component unmounts tunes[] should be cleaned up
  useEffect(() => {
    return () => {
      dispatch(cleanUpTunes());
      dispatch(setTunePage(0));
    };
  }, [dispatch]);

  return {
    tunes,
    searchQuery,
    autocompleteOptions,
    page,
    pageSize,
    totalEntities,
    loadNext,
    handleSearchQueryChange,
    handleAutocompleteChange,
  };
};
