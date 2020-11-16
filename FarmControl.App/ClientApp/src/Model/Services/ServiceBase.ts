import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Entity } from '../Entity';
import { getBaseUrl } from '../../main';

export abstract class ServiceBase<T extends Entity> {

  private url = getBaseUrl() + "AnimalType";

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' })
  };

  constructor(private http: HttpClient) {
    //this.url = getBaseUrl() + new TCreator().constructor.name;
  }

  /** GET heroes from the server */
  GetAll(): Observable<T[]> {
    return this.http.get<T[]>(this.url)
      .pipe(
        catchError(this.handleError<T[]>('getHeroes', []))
      );
  }

  /** GET hero by id. Return `undefined` when id not found */
  getByIdNonUndifined<Data>(id: number): Observable<T> {
    const url = `${this.url}/?id=${id}`;
    return this.http.get<T[]>(url)
      .pipe(
        map(entities => entities[0]), // returns a {0|1} element array
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
        }),
        catchError(this.handleError<T>(`getHero id=${id}`))
      );
  }

  /** GET hero by id. Will 404 if id not found */
  GetById(id: string): Observable<T> {
    const url = `${this.url}/${id}`;
    return this.http.get<T>(url).pipe(
      catchError(this.handleError<T>(`getHero id=${id}`))
    );
  }

  /* GET heroes whose name contains search term */
  searchAll(term: string): Observable<T[]> {
    if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<T[]>(`${this.url}/?name=${term}`).pipe(
      catchError(this.handleError<T[]>('searchHeroes', []))
    );
  }

  //////// Save methods //////////

  /** POST: add a new hero to the server */
  Add(entity: T){
    this.http.post<T>(this.url, entity, this.httpOptions).subscribe();
  }

  /** DELETE: delete the hero from the server */
  Delete(entity: T | number): Observable<T> {
    const id = typeof entity === 'number' ? entity : entity.Id;
    const url = `${this.url}/${id}`;

    return this.http.delete<T>(url, this.httpOptions).pipe(
      catchError(this.handleError<T>('deleteHero'))
    );
  }

  /** PUT: update the hero on the server */
  Update(entity: T): Observable<any> {
    return this.http.put(this.url, entity, this.httpOptions).pipe(
      catchError(this.handleError<any>('updateHero'))
    );
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
