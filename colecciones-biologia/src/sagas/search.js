import { call, takeEvery, put, select } from "redux-saga/effects";

import { API_BASE_URL } from "../settings";
import * as selectors from "../reducers";
import * as searchActions from "../actions/search";
import * as types from "../types/search";

function* searchSuggestions(action) {
  try {
    const response = yield call(
      fetch,
      `${API_BASE_URL}/api/organisms/search_suggestions_results/`,
      {
        method: "POST",
        body: JSON.stringify(action.payload),
        headers: {
          "Content-Type": "application/json",
        },
      }
    );

    if (response.status === 200) {
      const suggestions = yield response.json();
      yield put(searchActions.foundSuggestions({ suggestions }));
    } else {
      yield put(searchActions.foundSuggestions({ suggestions: [] }));
    }
  } catch (error) {
    yield put(searchActions.foundSuggestions({ suggestions: [] }));
  }
}

export function* watchSearchSuggestion() {
  yield takeEvery(types.SUGGESTIONS_SEARCHING, searchSuggestions);
}

function* search(action) {
  try {
    const response = yield call(
      fetch,
      `${API_BASE_URL}/api/organisms/search_results/`,
      {
        method: "POST",
        body: JSON.stringify(action.payload),
        headers: {
          "Content-Type": "application/json",
        },
      }
    );
    if (response.status === 200) {
      const results = yield response.json();
      yield put(searchActions.resultsFounded({ results }));
    } else {
      yield put(searchActions.resultsFounded({ results: [] }));
    }
  } catch (error) {
    yield put(searchActions.resultsFounded({ results: [] }));
  }
}

export function* watchSearch() {
  yield takeEvery(types.SEARCH_RESULTS, search);
}
