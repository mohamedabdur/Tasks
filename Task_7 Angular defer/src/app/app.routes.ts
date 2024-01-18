import { Routes } from '@angular/router';
import { HotelbookingComponent } from './hotelbooking/hotelbooking.component';
import { FlightBookingComponent } from './flight-booking/flight-booking.component';

export const routes: Routes = [
    {'path':'hotelbooking','title':'HotelBooking',component:HotelbookingComponent},
    {'path':'flightBooking','title':'FlightBooking',component:FlightBookingComponent}
];
