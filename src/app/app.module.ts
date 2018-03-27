import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import {PictureViewerComponent} from './pictureviewer.components'
import { ImageService } from './image.service';
import { HttpModule } from '@angular/http';
import { MasonryModule } from 'angular2-masonry';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { ShowAlbumComponent } from './showalbum.component';
import { LightboxModule } from 'angular2-lightbox';
import { ErrorComponent } from './error.component';
import { ContactComponent } from './contact.component';

@NgModule({
  declarations: [
    AppComponent,
    PictureViewerComponent,
    ShowAlbumComponent,
    ErrorComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    MasonryModule,
    RouterModule,
    AppRoutingModule,
    LightboxModule
  ],
  providers: [ImageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
