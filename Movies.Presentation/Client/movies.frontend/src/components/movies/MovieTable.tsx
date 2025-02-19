import { Container } from "semantic-ui-react";
import { useState , useEffect } from "react";
import { MovieDto } from "../../models/movieDto";
import apiConnection from "../../api/apiConnector";
import MovieTableItem  from "./MovieTableItem";

export default function MovieTable() {
    const [movies, setMovies] = useState<MovieDto[]>([]);

    useEffect(() => {
        const fetchMovies = async () => {
            const fetchedMovies = await apiConnection.getMovies();
            setMovies(fetchedMovies);
        };
        fetchMovies();
    }, []);
    
    return( 
    <>
     <Container className="container-style">
     <table className="ui inverted table">
                    <thead style={{textAlign: 'center'}}>
                    <tr>
                        <th>Id</th>
                        <th>Title</th>
                        <th>Description</th>
                        <th>CreateDate</th>
                        <th>Category</th>
                        <th>Action</th>
                    </tr>
                    </thead>
                    <tbody>
                    {movies.length !== 0 && (
                        movies.map((movie, index) => (
                            <MovieTableItem key={index} movie={movie}/>
                        ))
                    )}
                    </tbody>
                </table>
     </Container>
    </>
)
}