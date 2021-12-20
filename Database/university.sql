-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 05, 2017 at 05:08 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `university`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_tbl`
--

CREATE TABLE `admin_tbl` (
  `admin_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin_tbl`
--

INSERT INTO `admin_tbl` (`admin_id`, `name`, `email`, `password`) VALUES
(1, 'asif', 'asif@gmail.com', '123456'),
(2, 'anik', 'anik@gmail.com', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `assignments_tbl`
--

CREATE TABLE `assignments_tbl` (
  `assignment_id` int(11) NOT NULL,
  `course_id` varchar(50) NOT NULL,
  `student_id` varchar(50) NOT NULL,
  `dateOfSubmission` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course_tbl`
--

CREATE TABLE `course_tbl` (
  `course_id` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL,
  `credits` varchar(50) NOT NULL,
  `department_id` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course_tbl`
--

INSERT INTO `course_tbl` (`course_id`, `title`, `credits`, `department_id`) VALUES
('CSE3103', 'Database', '3', '04'),
('CSE3104', 'Database Lab', '1.5', '04'),
('CSE3107', 'Microprocessors', '3', '04'),
('CSE3109', 'Digital System Design', '3', '04');

-- --------------------------------------------------------

--
-- Table structure for table `department_tbl`
--

CREATE TABLE `department_tbl` (
  `department_id` varchar(50) NOT NULL,
  `dep_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department_tbl`
--

INSERT INTO `department_tbl` (`department_id`, `dep_name`) VALUES
('04', 'cse'),
('05', 'eee'),
('07', 'mpe');

-- --------------------------------------------------------

--
-- Table structure for table `lecture_tbl`
--

CREATE TABLE `lecture_tbl` (
  `lecture_id` int(11) NOT NULL,
  `topic` varchar(50) NOT NULL,
  `dateOfUpload` varchar(50) NOT NULL,
  `course_id` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `news_tbl`
--

CREATE TABLE `news_tbl` (
  `news_id` varchar(50) NOT NULL,
  `time` varchar(50) NOT NULL,
  `news_details` varchar(50) NOT NULL,
  `sort_des` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `result_tbl`
--

CREATE TABLE `result_tbl` (
  `quiz_number` varchar(50) NOT NULL,
  `attendance_number` varchar(50) NOT NULL,
  `final` varchar(50) NOT NULL,
  `number` varchar(50) NOT NULL,
  `grade` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `student_id` varchar(50) NOT NULL,
  `course_id` varchar(50) NOT NULL,
  `approved` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `result_tbl`
--

INSERT INTO `result_tbl` (`quiz_number`, `attendance_number`, `final`, `number`, `grade`, `year`, `student_id`, `course_id`, `approved`, `semester`) VALUES
('15', '10', '55', '80', 'A+', '16', '14.02.04.039', 'CSE3103', 'NO', '02');

-- --------------------------------------------------------

--
-- Table structure for table `student_takes`
--

CREATE TABLE `student_takes` (
  `student_id` varchar(50) NOT NULL,
  `course_id` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_takes`
--

INSERT INTO `student_takes` (`student_id`, `course_id`, `year`, `semester`) VALUES
('14.02.04.039', 'CSE3103', '16', '02'),
('14.02.04.039', 'CSE3107', '16', '02');

-- --------------------------------------------------------

--
-- Table structure for table `student_tbl`
--

CREATE TABLE `student_tbl` (
  `sec` varchar(50) NOT NULL,
  `sub_sec` varchar(50) NOT NULL,
  `department_id` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `total_credit` varchar(50) NOT NULL,
  `student_id` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `completed_credit` varchar(50) NOT NULL,
  `cgpa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_tbl`
--

INSERT INTO `student_tbl` (`sec`, `sub_sec`, `department_id`, `email`, `total_credit`, `student_id`, `year`, `semester`, `password`, `name`, `completed_credit`, `cgpa`) VALUES
('a', 'a2', '04', 'asif@gmail.com', '161', '14.02.04.034', '14', '02', '1234', 'Asif', '', ''),
('a', '2', '04', 'abc@gmail.com', '161', '14.02.04.039', '14', '02', '1234', 'Ishti', '99', '3.54'),
('a', 'a2', '04', 'anif@gmail.com', '161', '14.02.04.048', '14', '02', '1234', 'anik', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_takes`
--

CREATE TABLE `teacher_takes` (
  `teacher_id` varchar(50) NOT NULL,
  `course_id` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher_takes`
--

INSERT INTO `teacher_takes` (`teacher_id`, `course_id`, `year`, `semester`) VALUES
('1', 'CSE3103', '16', '02'),
('2', 'CSE3107', '16', '02');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_tbl`
--

CREATE TABLE `teacher_tbl` (
  `teacher_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `department_id` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher_tbl`
--

INSERT INTO `teacher_tbl` (`teacher_id`, `name`, `password`, `email`, `department_id`) VALUES
(1, 'Rahim', '4321', 'rahim@gmail.com', '04'),
(2, 'karim', '4321', 'karim@gmail.com', '04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_tbl`
--
ALTER TABLE `admin_tbl`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `assignments_tbl`
--
ALTER TABLE `assignments_tbl`
  ADD PRIMARY KEY (`assignment_id`),
  ADD KEY `course_id` (`course_id`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `course_tbl`
--
ALTER TABLE `course_tbl`
  ADD PRIMARY KEY (`course_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `department_tbl`
--
ALTER TABLE `department_tbl`
  ADD PRIMARY KEY (`department_id`);

--
-- Indexes for table `lecture_tbl`
--
ALTER TABLE `lecture_tbl`
  ADD PRIMARY KEY (`lecture_id`),
  ADD KEY `course_id` (`course_id`);

--
-- Indexes for table `news_tbl`
--
ALTER TABLE `news_tbl`
  ADD PRIMARY KEY (`news_id`);

--
-- Indexes for table `student_tbl`
--
ALTER TABLE `student_tbl`
  ADD PRIMARY KEY (`student_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `teacher_tbl`
--
ALTER TABLE `teacher_tbl`
  ADD PRIMARY KEY (`teacher_id`),
  ADD KEY `department_id` (`department_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_tbl`
--
ALTER TABLE `admin_tbl`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `assignments_tbl`
--
ALTER TABLE `assignments_tbl`
  MODIFY `assignment_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `lecture_tbl`
--
ALTER TABLE `lecture_tbl`
  MODIFY `lecture_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `teacher_tbl`
--
ALTER TABLE `teacher_tbl`
  MODIFY `teacher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `assignments_tbl`
--
ALTER TABLE `assignments_tbl`
  ADD CONSTRAINT `assignments_tbl_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course_tbl` (`course_id`),
  ADD CONSTRAINT `assignments_tbl_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student_tbl` (`student_id`);

--
-- Constraints for table `course_tbl`
--
ALTER TABLE `course_tbl`
  ADD CONSTRAINT `course_tbl_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `department_tbl` (`department_id`);

--
-- Constraints for table `lecture_tbl`
--
ALTER TABLE `lecture_tbl`
  ADD CONSTRAINT `lecture_tbl_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course_tbl` (`course_id`);

--
-- Constraints for table `student_tbl`
--
ALTER TABLE `student_tbl`
  ADD CONSTRAINT `student_tbl_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `department_tbl` (`department_id`);

--
-- Constraints for table `teacher_tbl`
--
ALTER TABLE `teacher_tbl`
  ADD CONSTRAINT `teacher_tbl_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `department_tbl` (`department_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
