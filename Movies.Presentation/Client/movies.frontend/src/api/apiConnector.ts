import axios , { AxiosResponse} from 'axios';
import { API_BASE_URL } from '../config';
import { GetMoviesResponse  } from '../models/getMoviesResponse';
import {GetMovieByIdResponse} from '../models/getMoviesByIdResponse';
import { MovieDto } from '../models/movieDto';

const apiConnection = {
    getMovies: async (): Promise<MovieDto[]> => {
        try {
            const response: AxiosResponse<GetMoviesResponse> = await axios.get(`${API_BASE_URL}/movies`);
            //console.log('API Response:', response.data);
            const movies = response.data.map(movie => ({
                ...movie,
                createDate: movie.createDate?.slice(0, 10) ?? ""
            }));
    
            console.log("Processed Movies:", movies);
            return movies;
        } catch (error) {
            console.error('Error fetching movies:', error);
            throw error;
        }
    },    

    createMovie: async (movie: MovieDto): Promise<void> => {
        try {
            await axios.post<number>(`${API_BASE_URL}/movies`, movie);
        } catch (error) {
            console.log('Error creating movie:', error);
            throw error;
        }
    },

    editMovie: async (movie: MovieDto): Promise<void> => {
        try {
            await axios.put<number>(`${API_BASE_URL}/movies`, movie);
        } catch (error) {
            console.log('Error creating movie:', error);
            throw error;
        }
    },

    deleteMovie: async (movieId: number): Promise<void> => {
        try {
            await axios.delete<number>(`${API_BASE_URL}/movies/${movieId}`);
        } catch (error) {
            console.log('Error creating movie:', error);
            throw error;
        }
    },

    getMovieById: async (movieId: number): Promise<MovieDto> => {
        try {
            const response: AxiosResponse<GetMovieByIdResponse> = await axios.get(`${API_BASE_URL}/movies/${movieId}`);
            return response.data.movieDto;
        } catch (error) {
            console.log('Error fetching movie by ID:', error);
            throw error;
        }
    }
};

export default apiConnection;